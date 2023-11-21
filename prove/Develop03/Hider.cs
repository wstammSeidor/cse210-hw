public class Hider{
    private List<int> indexHiddenWords;

    public Hider(){
        indexHiddenWords = new List<int>();
    }

    public void AddIndexHiddenWord(int index){
        indexHiddenWords.Add(index);
    }

    public bool IsHiddenWord(int index){
        return indexHiddenWords.Contains(index);
    }

    
}