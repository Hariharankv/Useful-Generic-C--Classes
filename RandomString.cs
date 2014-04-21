using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using System.Text;

/// <summary>
/// Summary description for RandomString
/// </summary>
public class RandomString
{
   

    public RandomString()
    {
        //
        // TODO: Add constructor logic here
        //
    }

     public string Generate() 
     {
        string _keyLetters = "abcdefghijklmnopqrstuvwxyz";
        string _keyNumbers = "0123456789";
        int _keyChars = 6;
        char[] _lettersArray;
        char[] _numbersArray;

        StringBuilder Objsb = new StringBuilder();
       
        _lettersArray = _keyLetters.ToCharArray();
        _numbersArray = _keyNumbers.ToCharArray();
        Random random = new Random();
        for(int iKey = 1;iKey<= _keyChars;iKey++)
        {
             if ((random.Next() % 2) == 0)
             {
                 Objsb.Append(_numbersArray[random.Next(0, 9)]);
             }
             else
             {
                 Objsb.Append(_lettersArray[random.Next(0, 26)]);
             }
            
        }
        random = null;
        return Objsb.ToString();
     }
    
}
