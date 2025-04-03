using System.Dynamic;

namespace ColorSpheres
{
    public class Color
    {
        /// variavel de instancia para os valores em byte de cada cor, e opacidade 
        private readonly byte _red;
        private readonly byte _green;
        private readonly byte _blue;
        private readonly byte _alpha;

        /// construtor que aceita todos os parametros necessários
        public Color(byte red, byte green, byte blue, byte alpha)
        {
            _red = red;
            _green = green;
            _blue = blue;
            _alpha = alpha;
        }

        /// contrutor que aceita apenas os parametros de cor e define opacidade
        public Color(byte red, byte green, byte blue)
        {
            _red = red;
            _green = green;
            _blue = blue;
            _alpha = 255;
        }

        public byte GetRed()
        {
            return _red;
        }
         public byte GetGreen()
        {
            return _green;
        }
         public byte GetBlue()
        {
            return _blue;
        }
         public byte GetAlpha()
        {
            return _alpha;
        }

        public byte GetGrey()
        {
            return (byte)((_red + _blue + _green)/3);
        }



    }
}