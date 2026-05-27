using System;
using System.Drawing;
using System.Windows.Forms;

namespace CyberGuard
{
    public partial class MainForm : Form
    {
        private ChatBot bot;
        private User user;
        private MemoryManager memory;
        private SentimentAnalyzer sentiment;
        private ResponseSystem responseSystem;

        private int questionCount = 0;

        public MainForm()
        {
            InitializeComponent();

            bot = new ChatBot();
            responseSystem = bot.ResponseSystem;

            user = new User();
            memory = new MemoryManager(user);
            sentiment = new SentimentAnalyzer();

            LoadTopics();

            bot.PlayGreeting();

            AddBotMessage(
                "Welcome to the Cybersecurity Awareness Chatbot!");

            UpdateStats();
        }

        // ASCII logo for chatbot
        public static string[] AsciiLogo =
        {
        

         "┌─────────────────┐",
         "│  █▀▀ █▄█ █▄▄    │",
         "│  █▄▄ ░█░ █▄█ 🔐 │",
         "│  Security Bot   │",
          "└─────────────────┘"

         };
        private object txtOutput;

        // Load cybersecurity topics
        private void LoadTopics()
        {
            lstTopics.Items.Clear();

            lstTopics.Items.AddRange(AsciiLogo);

            lstTopics.Items.Add("Password Safety");
            lstTopics.Items.Add("Phishing");
            lstTopics.Items.Add("Privacy");
            lstTopics.Items.Add("Scams");
            lstTopics.Items.Add("Malware");
            lstTopics.Items.Add("Social Engineering");
            lstTopics.Items.Add("Safe Browsing");
        }

        

        private void btnSend_Click(object sender, EventArgs e)
        {
            string input = txtMessage.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show(
                    "Please enter a question.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            questionCount++;

            string displayName =
                string.IsNullOrWhiteSpace(user.Name)
                ? "User"
                : user.Name;

            AddUserMessage(displayName, input);

            HandleMemory(input);

            Sentiment mood =
                sentiment.Detect(input);

            string reply =
                BuildResponse(input, mood);

            AddBotMessage(reply);

            txtMessage.Clear();

            UpdateStats();
        }

        private void HandleMemory(string input)
        {
            string lower = input.ToLower();

            if (lower.Contains("interested in privacy"))
            {
                memory.SaveFavouriteTopic("Privacy");

                AddBotMessage(
                    "Great! I'll remember that you're interested in Privacy.");
            }

            else if (lower.Contains("interested in password"))
            {
                memory.SaveFavouriteTopic("Password Safety");

                AddBotMessage(
                    "Great! I'll remember that you're interested in Password Safety.");
            }

            else if (lower.Contains("interested in phishing"))
            {
                memory.SaveFavouriteTopic("Phishing");

                AddBotMessage(
                    "Great! I'll remember that you're interested in Phishing Awareness.");
            }

            else if (lower.Contains("interested in malware"))
            {
                memory.SaveFavouriteTopic("Malware");

                AddBotMessage(
                    "Great! I'll remember that you're interested in Malware Protection.");
            }
        }

        private string BuildResponse(
            string input,
            Sentiment mood)
        {
            string response =
                bot.Respond(input);

            switch (mood)
            {
                case Sentiment.Worried:

                    response =
                        "It is understandable to feel worried. "
                        + response;

                    lblMood.Text =
                        "Current Mood: Worried";

                    break;

                case Sentiment.Curious:

                    response =
                        "Great question. "
                        + response;

                    lblMood.Text =
                        "Current Mood: Curious";

                    break;

                case Sentiment.Frustrated:

                    response =
                        "I understand your frustration. "
                        + response;

                    lblMood.Text =
                        "Current Mood: Frustrated";

                    break;

                default:

                    lblMood.Text =
                        "Current Mood: Normal";

                    break;
            }

            string favourite =
                memory.RecallTopic();

            if (!string.IsNullOrEmpty(favourite))
            {
                response += Environment.NewLine
                         + Environment.NewLine;

                switch (favourite)
                {
                    case "Privacy":

                        response +=
                            "Since privacy interests you, review account security settings regularly.";
                        break;

                    case "Password Safety":

                        response +=
                            "Use strong and unique passwords for every account.";
                        break;

                    case "Phishing":

                        response +=
                            "Always verify suspicious emails before opening links.";
                        break;

                    case "Malware":

                        response +=
                            "Keep your antivirus and software updated.";
                        break;
                }
            }

            return response;
        }

        private void UpdateStats()
        {
            lblQuestions.Text =
                "Questions Asked: "
                + questionCount;

            lblUser.Text =
                "User: "
                + (string.IsNullOrWhiteSpace(user.Name)
                ? "Not Set"
                : user.Name);

            lblFavourite.Text =
                "Favourite Topic: "
                + (memory.RecallTopic() ?? "None");

            lblLastTopic.Text =
                "Last Topic: "
                + (responseSystem.GetLastTopic()
                ?? "None");
        }

        private void btnSetName_Click(
            object sender,
            EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(
                txtName.Text))
            {
                user.Name =
                    txtName.Text;

                UpdateStats();

                AddBotMessage(
                    "Nice to meet you "
                    + user.Name
                    + "!");
            }
        }

        private void exitToolStripMenuItem_Click(
            object sender,
            EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to exit?",
                    "Exit",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void AddBotMessage(
            string message)
        {
            txtConversation.SelectionStart =
                txtConversation.TextLength;

            txtConversation.SelectionColor =
                Color.Red;

            txtConversation.AppendText(
                "CyberGuard: ");

            txtConversation.SelectionColor =
                Color.Black;

            txtConversation.AppendText(
                message
                + Environment.NewLine
                + Environment.NewLine);

            txtConversation.SelectionColor =
                txtConversation.ForeColor;
        }

        private void AddUserMessage(
            string username,
            string message)
        {
            txtConversation.SelectionStart =
                txtConversation.TextLength;

            txtConversation.SelectionColor =
                Color.Green;

            txtConversation.AppendText(
                username + ": ");

            txtConversation.SelectionColor =
                Color.Black;

            txtConversation.AppendText(
                message
                + Environment.NewLine
                + Environment.NewLine);

            txtConversation.SelectionColor =
                txtConversation.ForeColor;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void lstTopics_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}