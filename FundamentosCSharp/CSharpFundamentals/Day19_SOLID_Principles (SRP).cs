namespace CSharpFundamentals
{
    public static class Day19_SOLID_Principles__SRP_
    {
        public static void ExecuteEmailSender()
        {
            //Demostration of code that violates SRP
            Console.WriteLine("Demostration of code that violates SRP");
            EmailSender oldEmailSender = new EmailSender();
            oldEmailSender.SendInvoiceEmail("testing@gmail.com", 123);


            //--------------------------------------------------------------
            Console.WriteLine("-------------------------------------------------");
            //Demostration of code that uses SRP
            Console.WriteLine("Demostration of code that uses SRP");
            InvoiceEmailContentCreator contentCreator = new InvoiceEmailContentCreator();
            EmailService emailService = new EmailService();

            string recipient = "customer@example.com";
            double invoiceAmount = 456.78;

            string emailBody = contentCreator.CreateEmailBody(invoiceAmount);
            emailService.SendEmail(recipient, emailBody);


        }



    }
}



/// <summary>
// Handles sending emails to customers
/// </summary>
/// <remarks>
/// This class violates the Single Responsability Principle(SRP)
/// as it resposinble for both creating the email content and sending it.
/// <remarks>

public class EmailSender
{
    public void SendInvoiceEmail(string recipientEmail, double amount)
    {
        string emailBody = "Dear customer, your invoice is for $" + amount + ". Thank you for your business.";
        Console.WriteLine($"Creating email for {recipientEmail}...");
        Console.WriteLine($"Sending email with body: '{emailBody}' to {recipientEmail}...");
    }
}

/// <summary>
/// The ideal is creates two class for each action and desacopling the responsability in one class
/// </summary>
// Single Responsibility: Creating the email content
public class InvoiceEmailContentCreator
{
    public string CreateEmailBody(double amount)
    {
        return $"Dear customer, your invoice is for ${amount}. Thank you for your business.";
    }
}

// Single Responsibility: Sending the email
public class EmailService
{
    public void SendEmail(string recipientEmail, string emailBody)
    {
        Console.WriteLine($"Sending email with body: '{emailBody}' to {recipientEmail}...");
    }
}