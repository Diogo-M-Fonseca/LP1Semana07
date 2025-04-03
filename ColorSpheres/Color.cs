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



    }
}