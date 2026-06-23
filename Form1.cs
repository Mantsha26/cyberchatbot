using System;
using System.Collections.Generic;
using System.Linq;
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
        private ActivityLog activityLog;
        private QuizManager quizManager;
        private NLPProcessor nlp;

        private int questionCount = 0;
        private bool quizActive = false;

        public MainForm()
        {
            InitializeComponent();

            bot = new ChatBot();
            responseSystem = bot.ResponseSystem;

            user = new User();
            memory = new MemoryManager(user);
            sentiment = new SentimentAnalyzer();

            // Initialize auxiliary managers
            activityLog = new ActivityLog();
            quizManager = new QuizManager();
            nlp = new NLPProcessor();

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

            grpQuiz.Visible = false;
            string displayName =
                string.IsNullOrWhiteSpace(user.Name)
                ? "User"
                : user.Name;

            AddUserMessage(displayName, input);

            HandleMemory(input);
            string intent =
    nlp.DetectIntent(input);

            if (intent == "LOG")
            {
                AddBotMessage(
                    activityLog.GetLogText());

                return;
            }

            if (intent == "QUIZ")
            {
                // Reset the quiz so the user can take it multiple times
                quizManager.Reset();
                quizActive = true;
                grpQuiz.Visible = true;
                btnNextQuestion.Enabled = true;
                lblFeedback.Text = string.Empty;

                LoadQuizQuestion();

                activityLog.Add("Quiz Started");

                return;
            }

            Sentiment mood =
                sentiment.Detect(input);

            if (quizActive && !quizManager.IsFinished() &&
    quizManager.GetCurrentQuestion() != null)
            {
                // If the user input contains topic keywords, treat it as normal chat
                // instead of submitting as a quiz answer.
                string lowerInput = input.ToLower();
                string[] topicKeywords = { "password", "phishing", "privacy", "scam", "malware" };

                bool isTopicQuery = topicKeywords.Any(k => lowerInput.Contains(k));

                if (isTopicQuery)
                {
                    // Respond as normal chat and do not advance the quiz
                    string chatReply = BuildResponse(input, mood);
                    AddBotMessage(chatReply);
                    txtMessage.Clear();
                    UpdateStats();
                    return;
                }

                string result =
                    quizManager.SubmitAnswer(input);

                AddBotMessage(result);

                activityLog.Add(
                    "Quiz answer submitted");

                if (quizManager.IsFinished())
                {
                    AddBotMessage(
                        "Quiz Complete! Score: "
                        + quizManager.Score
                        + "/" + quizManager.TotalQuestions);

                    activityLog.Add(
                        "Quiz completed. Score: "
                        + quizManager.Score);
                }
                else
                {
                    AddBotMessage(
                        quizManager
                        .GetCurrentQuestion()
                        .Question);
                }
                if (quizManager.IsFinished())
                {
                    string feedback;

                    if (quizManager.Score >= 13)
                        feedback = "Great job! You're a cybersecurity pro!";
                    else if (quizManager.Score >= 8)
                        feedback = "Good work! You have solid cybersecurity knowledge.";
                    else
                        feedback = "Keep learning to stay safe online!";

                    MessageBox.Show(
                        "Quiz Complete!\n\nScore: "
                        + quizManager.Score
                        + "/" + quizManager.TotalQuestions + "\n\n"
                        + feedback,
                        "Quiz Results");

                    btnNextQuestion.Enabled = false;
                    // Deactivate quiz mode and hide quiz UI so normal chat resumes
                    quizActive = false;
                    grpQuiz.Visible = false;
                }

                return;
            }
            // Use NLPProcessor to detect add-task intent and extract a title
            string detectedIntent = intent; // already retrieved above
            if (detectedIntent == "ADD_TASK")
            {
                string title = nlp.ExtractTaskTitle(input);

                AddTask(title);

                return;
            }
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
            // Only record activity when a topic was actually saved
            if (lower.Contains("interested in privacy"))
            {
                activityLog.Add("Favourite topic saved: Privacy");
            }
            else if (lower.Contains("interested in password"))
            {
                activityLog.Add("Favourite topic saved: Password Safety");
            }
            else if (lower.Contains("interested in phishing"))
            {
                activityLog.Add("Favourite topic saved: Phishing");
            }
            else if (lower.Contains("interested in malware"))
            {
                activityLog.Add("Favourite topic saved: Malware");
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
                activityLog.Add(
    "User name set to "
    + user.Name);
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

            // show bot message in white to match dark background
            txtConversation.SelectionColor =
                Color.White;

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

            // show user messages in white for readability on dark background
            txtConversation.SelectionColor =
                Color.White;

            txtConversation.AppendText(
                username + ": ");

            txtConversation.SelectionColor =
                Color.White;

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

        private List<CyberTask> tasks =
    new List<CyberTask>();

        private void AddTask(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Please enter a task title.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CyberTask task = new CyberTask();
            task.Title = title;

            // If the task description textbox is available, use it; otherwise keep a default
            try
            {
                task.Description = string.IsNullOrWhiteSpace(txtTaskDesc.Text)
                    ? "Cybersecurity Task"
                    : txtTaskDesc.Text;
            }
            catch
            {
                task.Description = "Cybersecurity Task";
            }

            // Set reminder if requested
            try
            {
                if (chkReminder.Checked)
                {
                    task.ReminderDate = dtpReminder.Value.Date;
                }
            }
            catch
            {
                task.ReminderDate = null;
            }

            task.Completed = false;

            tasks.Add(task);

            // Add to UI listbox so the user sees it
            lstTasks.Items.Add(task);

            activityLog.Add("Task added: " + title);
            AddBotMessage("Task added: " + title);

            // Clear input fields
            try { txtTaskTitle.Clear(); txtTaskDesc.Text = "Enter task description..."; chkReminder.Checked = false; }
            catch { }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            try
            {
                AddTask(txtTaskTitle.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add task: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCompleteTask_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a task to mark complete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selected = lstTasks.SelectedItem as CyberTask;

            if (selected == null)
            {
                MessageBox.Show("Selected item is not a valid task.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            selected.Completed = true;

            // Refresh the selected item in the listbox so ToString shows updated state
            int idx = lstTasks.SelectedIndex;
            lstTasks.Items[idx] = selected;

            activityLog.Add("Task completed: " + selected.Title);
            AddBotMessage("Task marked complete: " + selected.Title);
        }

        private void LoadQuizQuestion()
        {
            QuizQuestion q = quizManager.GetCurrentQuestion();

            if (q == null)
            {
                lblFeedback.Text = "Quiz Completed!";
                return;
            }

            lblQuizQuestion.Text = q.Question;

            rbOptionA.Text = q.OptionA;
            rbOptionB.Text = q.OptionB;
            rbOptionC.Text = q.OptionC;
            rbOptionD.Text = q.OptionD;

            rbOptionA.Checked = false;
            rbOptionB.Checked = false;
            rbOptionC.Checked = false;
            rbOptionD.Checked = false;

            lblScore.Text = "Score: " + quizManager.Score + "/10";
        }
        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            string selectedAnswer = "";

            if (rbOptionA.Checked)
                selectedAnswer = "A";
            else if (rbOptionB.Checked)
                selectedAnswer = "B";
            else if (rbOptionC.Checked)
                selectedAnswer = "C";
            else if (rbOptionD.Checked)
                selectedAnswer = "D";

            if (selectedAnswer == "")
            {
                MessageBox.Show(
                    "Please select an answer first.");
                return;
            }

            QuizQuestion currentQuestion =
                quizManager.GetCurrentQuestion();

            // Defensive: if there's no current question the quiz is finished
            if (currentQuestion == null)
            {
                MessageBox.Show("No active question. The quiz has finished.");
                btnNextQuestion.Enabled = false;
                return;
            }

            if (selectedAnswer ==
                currentQuestion.CorrectAnswer)
            {
                lblFeedback.Text = "Correct!";
            }
            else
            {
                lblFeedback.Text =
                    "Incorrect! " +
                    currentQuestion.Explanation;
            }

            quizManager.SubmitAnswer(selectedAnswer);

            lblScore.Text =
                "Score: " +
                quizManager.Score +
                "/10";

            if (!quizManager.IsFinished())
            {
                LoadQuizQuestion();
            }
            else
            {
                string summary = quizManager.GetAnswersSummary();

                MessageBox.Show(
                    "Quiz Complete!\nScore: " +
                    quizManager.Score +
                    "/" + quizManager.TotalQuestions +
                    "\n\nCorrect Answers:\n" + summary,
                    "Quiz Results");

                activityLog.Add(
                    "Quiz completed. Score: " +
                    quizManager.Score);
                btnNextQuestion.Enabled = false;
                // Deactivate quiz mode and hide quiz UI so normal chat resumes
                quizActive = false;
                grpQuiz.Visible = false;
            }
        }
        private void btnEndQuiz_Click(
    object sender,
    EventArgs e)
        {
            string summary = quizManager.GetAnswersSummary();

            MessageBox.Show(
                "Final Score: " +
                quizManager.Score +
                "/" + quizManager.TotalQuestions +
                "\n\nCorrect Answers:\n" + summary,
                "Quiz Results");

            grpQuiz.Visible = false;

            // Reset quiz state so user can take it again later
            quizManager.Reset();
            btnNextQuestion.Enabled = true;

            // ensure quiz mode is off
            quizActive = false;

            activityLog.Add(
                "Quiz ended manually.");
        }

    }


}