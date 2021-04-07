using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QRCoder;
using System.Drawing;

namespace QRCodeAddress.QRGenerator
{
    public class Generator
    {
        //method to create new instance of QRCodeGenerator and receive input from user and generate QR code as bmp
        public void QRGenerate()
        {
            QRCodeGenerator generator = new QRCodeGenerator();
            Console.WriteLine("Please Input an address: ");
            string Address = Console.ReadLine();
            QRCodeData qrCodeData = generator.CreateQrCode(Address, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            qrCodeImage.Save("Address.bmp");
           
        }
    }
}
