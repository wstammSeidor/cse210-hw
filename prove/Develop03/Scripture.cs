public class Scripture{
        private Referece _reference ;
        private List<Word> _words ;

        public Scripture(Referece reference, List<Word> words){
            _reference = reference;
            _words = words;
        }

        public void HideRandomWords(int numberToHide){
            Random random = new Random();
            int randomIndex = 0;
            for(int i = 0; i < numberToHide; i++){
                randomIndex = random.Next(0, _words.Count);
                _words[randomIndex].Hide();
            }
        }

        public string GetDisplayText(){
            string displayText = _reference.GetDisplayText() + "\n";
            foreach(Word word in _words){
                displayText += word.GetDisplayText() + " ";
            }
            return displayText;
        }

        public bool isCompletelyHidden(){
            foreach(Word word in _words){
                if(!word.isHidden()){
                    return false;
                }
            }
            return true;
        }

        

}