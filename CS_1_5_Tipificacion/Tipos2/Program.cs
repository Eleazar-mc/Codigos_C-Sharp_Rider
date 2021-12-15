namespace Tipos2
{
    interface I1 {
        void F();
    }

    interface I2 {
        int F(int i);
    }

    interface I3 {
        int F();
    }

    class C {
        public int F() {
            return 1;
        }
    }

class C2 : I1, I2 {
    public void F() {}
    public int F(int i) {
        return 1;
    }
}

    class C3 : C, I2 {
        public int F(int i) {
            return 1;
        }
    }

    class C4 : C, I3 {
    // Identical, no problem:
        public new int F() {
            return 1;
        }
    }
    
    class C5 : C, I1 {
        public new void F() {}
    }
    
    //interface I4 : I1, I3 {}
}