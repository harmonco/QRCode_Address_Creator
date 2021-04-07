using System;
using QRCodeAddress.QRGenerator;
using System.Drawing;

namespace QRCodeAddress
{
    class Program
    {
        static void Main(string[] args)
        {
            //ceate new instance of class Generator and call QRGenerate method
            Generator makeanaddres = new Generator();
            makeanaddres.QRGenerate();
        }
    }
}
