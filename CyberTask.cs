using System;

public class CyberTask
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public DateTime? ReminderDate { get; set; }

    public bool Completed { get; set; }

    public override string ToString()
    {
        return Title +
               " | " +
               Description +
               " | Reminder: " +
               (ReminderDate.HasValue
               ? ReminderDate.Value.ToShortDateString()
               : "None") +
               " | Completed: " +
               Completed;
    }
}