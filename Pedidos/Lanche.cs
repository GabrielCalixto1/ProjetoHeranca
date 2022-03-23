namespace finaldesemana2.Pedidos
{
    public class Lanche
    {

        public double LancheNormal { get; private set; }
        public double AdicionalDuplo { get; private set; }

        public Lanche()
        {
            LancheNormal = 30;
            AdicionalDuplo = (LancheNormal * 1.5);
        }
    }
}