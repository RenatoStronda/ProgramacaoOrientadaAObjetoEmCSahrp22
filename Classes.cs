namespace Classes{
    public class Calculadora{
      private float v1;
      private float v2;

      public float somar(float v1, float v2){
        this.v1 = v1;
        this.v2 = v2;
        return this.v1 + this.v2;
      }
    
      public float subtrair(float v1, float v2){
        this.v1 = v1;
        this.v2 = v2;
        return this.v1 - this.v2;
      }

      public float multiplicar(float v1, float v2){
        this.v1 = v1;
        this.v2 = v2;
        return this.v1 * this.v2;
      }

      public float divisao(float v1, float v2){
        this.v1 = v1;
        this.v2 = v2;
        return this.v1 / this.v2;
      }  
  }

      public class CalcSE{
        public float somar(float v, float v2){
          return v + v2;
        }
      
        public float subtrair(float v, float v2){
          return v - v2;
        }

        public float multiplicar(float v, float v2){
          return v * v2;
        }

        public float divisao(float v, float v2){
          return v / v2;
        }
  } 
}