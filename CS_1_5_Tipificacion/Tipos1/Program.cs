namespace Tipos1
{
    interface IMonster
    {
        public void Menace();
    }

    interface IDangerousMonster : IMonster
    {
        public void Destroy();
    }

    interface ILethal
    {
        public void Kill();
    }

    class DragonZilla : IDangerousMonster
    {
        public void Menace()
        {
        }

        public void Destroy()
        {
        }
    }

    interface IVampire : IDangerousMonster, ILethal
    {
        public void DrinkBlood();
    }

    class VeryBadVampire : IVampire
    {
        public void Menace()
        {
        }

        public void Destroy()
        {
        }

        public void Kill()
        {
        }

        public void DrinkBlood()
        {
        }
    }

    class HorrorShow
    {
        static void U(IMonster b)
        {
            b.Menace();
        }

        static void V(IDangerousMonster d)
        {
            d.Menace();
            d.Destroy();
        }

        static void W(ILethal l)
        {
            l.Kill();
        }

        public static void Main()
        {
            IDangerousMonster barney = new DragonZilla();
            HorrorShow.U(barney);
            HorrorShow.V(barney);
            IVampire vlad = new VeryBadVampire();
            HorrorShow.U(vlad);
            HorrorShow.V(vlad);
            HorrorShow.W(vlad);
        }
    }
}