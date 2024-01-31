namespace Frazione
{
    internal class Frazione
    {
        public Frazione(int numeratore, int denominatore)
        {
            Numeratore = numeratore;
            Denominatore = denominatore;
        }

        public int Numeratore { get; set; }
        public int Denominatore { get; set; }

      public void Semplifica (ref int numeratore, ref int denominatore)
        {
            int mcd=MCD(numeratore,denominatore);

            numeratore /= mcd;
            denominatore /= mcd;


        }
         public int MCD(int a, int b)
        {
            int resto;

            while (b != 0)
            {
                resto = a % b;
               a =b;
                b = resto;
            }
            return a;
        }

        public static Frazione Parse(string s)
        {
            string[] NumDen = s.Split('/');
            if (NumDen.Length == 2 && int.TryParse(NumDen[0], out int numeratore ) && int.TryParse(NumDen[1], out int denominatore))
            {

                return new Frazione(numeratore , denominatore);
            }
            else { return null;  }
        }

        public override string ToString()
        {
            return string.Format("{0} / {1}", Numeratore, Denominatore);
        }
    }
}
