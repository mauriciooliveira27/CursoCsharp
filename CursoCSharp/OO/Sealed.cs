using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public class Avo
    {
        public virtual bool HonrarNome() 
        { 
            return true; 
        }
    }

    public class Pai : Avo
    {
        public override sealed bool HonrarNome()
        {
            return true;
        }
    }

    public class Filho : Pai
    {
        public  bool HonrarNome()
        {  
            
            return false;
        
        }
    }
    public class Sealed
    {
        public static void Executar()
        {

        }
    }
}
