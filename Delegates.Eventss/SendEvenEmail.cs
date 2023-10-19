namespace Delegates.Eventss
{
    public  class SendEvenEmail
    {
        public event Func<Email, ValueTask> OnEmailCreated;
        public async ValueTask CreateEmailStore(Email email)
        {
            if (OnEmailCreated != null)
                await OnEmailCreated(this, email);
        }
    }
}