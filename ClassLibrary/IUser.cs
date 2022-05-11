namespace ClassLibrary
{
    public interface IUser
    {
        string Biography { get; set; }
        string ConfirmPassword { get; set; }
        string Email { get; set; }
        bool IsValid { get; set; }
        string Password { get; set; }
        PlanPayment Plan { get; set; }
        string Username { get; set; }
        string YoutubeAccount { get; set; }

        void CancelPlan();
        void ChangeBiography();
        void ChangePassword();
        void UpdatePlan();
    }
}