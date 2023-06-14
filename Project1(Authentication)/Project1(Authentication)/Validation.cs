namespace Project1_Authentication_
{
    internal class Validation
    {
        public bool Name(string name)
        {
            if (name.Length < 2)
            {
                return false;
            }
            return true;
        }

        public bool Password(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }
            if (!password.Any(char.IsUpper))
            {
                return false;
            }
            if (!password.Any(char.IsLower))
            {
                return false;
            }
            if (!password.Any(char.IsDigit))
            {
                return false;
            }
            return true;
        }

        public bool angka(string angka)
        {
            bool berhasil = int.TryParse(angka, out int number);
            if (!berhasil)
            {
                return false;
            }
            return true;
        }

        public bool role(string account)
        {
            if (account == "Admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
