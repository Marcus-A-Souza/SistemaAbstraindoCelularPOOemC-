using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone { }
    
        namespace DesafioPOO.Models
    {
        // TODO: Herdar da classe "Smartphone"
        public class Iphone : Smartphone
        {
            // TODO: Sobrescrever o método "InstalarAplicativo"
            public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
            {

            }

            public override void InstalarAplicativo(string nomeApp)
            {
                Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no Iphone");
            }
        }
    }
}
