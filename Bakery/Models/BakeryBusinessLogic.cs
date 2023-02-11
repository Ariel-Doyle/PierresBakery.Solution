namespace BakeryStoreFront.Models
{
  public class Bread
  {
   private static int _priceOfBread = 500;
    private static int _discountLoafGroup = 3; 
    private static int _BreadFormula(int numberOfLoaves)
    {
      int chargePerGroup = _discountLoafGroup - 1;
      int numberOfGroups = numberOfLoaves / _discountLoafGroup;
      int extraLoaves = numberOfLoaves % _discountLoafGroup;

      return ((chargePerGroup * numberOfGroups) + extraLoaves);
    }
     public static double DetermineBreadPrice(int numberOfLoaves)
    {
      return 0.01 * _priceOfBread * _BreadFormula(numberOfLoaves);
    } 
  }
}