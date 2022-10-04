using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //interface bir şablon görevi görür ve bu interfacei kullanan şablona uymak zorundadır 
    //interface kullanan sınıflar asagıdaki iki fonk. da içersinde barındırmalıdır
    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();
    }
}
