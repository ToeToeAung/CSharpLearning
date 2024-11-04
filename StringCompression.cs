using System.Text;

public class StringCompression{
        public string CompressedString(string word) {
     var length = 0;
     var result = new StringBuilder();
        for(var i=0;i<word.Length;i++){
            length += 1;
            if(i+1 == word.Length || word[i+1] != word[i] || length == 9){
                result.Append($"{length}{word[i]}");
                length = 0;
            }
        }
        
        return result.ToString();
    }
}