using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventExample
{
    class Subject
    {
        public event EventHandler<MyArgs> OnChange = delegate { };
        private void NotificarMudancaFase()
        {
            OnChange(this, new MyArgs(10));
        }

        public void MudarFase()
        {
            NotificarMudancaFase();
        }
    }
}
