using projekttovarna.Tridy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_továreň.Tridy
{
    internal class Továrna
    {
        Dictionary<string, string> TeslaIndustries = new Dictionary<string, string>();
         
        public Továrna()
        {
            TeslaIndustries.Add("model3", "https://teslaczech.com/wp-content/uploads/2021/03/rhd-model-3-social-800x445.png");
            TeslaIndustries.Add("modelS", "https://tesla-cdn.thron.com/delivery/public/image/tesla/538ac149-d103-4834-9d38-641d8ae447ef/bvlatuR/std/4096x2560/Homepage-Model-S-Desktop-LHD");
            TeslaIndustries.Add("modelX", "https://tesla-cdn.thron.com/delivery/public/image/tesla/ddc135ed-1638-40fb-8ab1-f8045059ecef/bvlatuR/std/4096x2560/Homepage-Model-X-Desktop-LHD");
            TeslaIndustries.Add("modelY", "https://tesla-cdn.thron.com/delivery/public/image/tesla/8e2df1b9-a4bf-4eb9-beec-2cf5cc77fca0/bvlatuR/std/2880x2400/Desktop-ModelY?quality=70");
            TeslaIndustries.Add("cybertruk", "https://cdn.24net.cz/5/obrazek/tesla-cybertruck-32059/260w");
        }

        public Auto VytvorAuto()
        {
            Console.Clear();

            Auto vyrobeneAuto = new Auto();
            return vyrobeneAuto;
        }

        public void Vytvorstranku(Auto vyrobeneAuto)
        {
            string html = $@"
            <html>
            <body>
            <h1>Továrna na auta</h1>
            <h2 style='color:blue;'>{vyrobeneAuto.Znacka}</h2>
            <h2>{vyrobeneAuto.Auto}</h2>
            <h2>Počet sedaček: {vyrobeneAuto.PocetSedadel1}</h2>
            <h2>Druh pohonu: {vyrobeneAuto.DruhPohonu}</h2>
            <img  src='{vyrobeneAuto.Obrazek}'>
            <h3>Rok výroby: {vyrobeneAuto.RokVyroby}</h3>
            <hr>
            <div>
            Cena: <h4 style='color: orange;'>{vyrobeneAuto.Cena}</h4>
            </div>
            </body>
            </html>";
            File.WriteAllText("index.html", html);

            public void ZobrazStranku(string adresaSouboru)
            {
                var process = new System.Diagnostics. ProcessStartInfo();
                process.UseShellExecute = true;
                process.UseShellExecute = adresaSouboru;
                System.Diagnostics.Process.Start(process);
            }
    }
}
