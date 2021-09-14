using Models;

namespace Business.Repository.IRepository
{
    public interface IEmailRepository
    {
        public void SendMail(EmailDTO email); 
    }
}