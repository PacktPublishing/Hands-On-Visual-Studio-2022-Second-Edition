namespace Chapter4_Code_Snippets
{
    public partial class Form1 : Form
    {
        int minimumLenght = 5;
        bool includeSpecialCharacters = false;

        public Form1()
        {
            InitializeComponent();
        }

        private string GeneratePassword(bool includeSpecialCharacters)
        {
            string allowedChars = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789";
            string allowedSpecialChars = "*$-+?_&=!%{}/";
            char[] chars = new char[minimumLenght];
            Random rd = new Random();

            for (int i = 0; i < minimumLenght; i++)
            {
                chars[i] = allowedChars[rd.Next(0, allowedChars.Length)];
            }

            if (includeSpecialCharacters)
            {
                chars[rd.Next(0, chars.Length)] = allowedSpecialChars[rd.Next(0, allowedSpecialChars.Length)];
            }

            return new string(chars);
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            bool includeSpecialCharacters = chkIncludeSpecialCharacters.Checked;
            string newPassword = GeneratePassword(includeSpecialCharacters);
            txtPassword.Text = newPassword;
        }
    }
}