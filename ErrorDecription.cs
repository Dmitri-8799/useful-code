

//Model
public class ErrorDescription
{
  
public int IdOdError {get;set;}
public string ErrorMessage {get;set;}

}


//ViewModel
public class ChoiceOfErrorMessageViewModel
{
  UserService userService = new UserService ();

 int? indexOfError;

      public ChoiceOfErrorMessage(UserService _userService)
      {
        _userService = userService;
        ChoiceOfErrorCommand => new Command (async =>(obj parameter) SetErrorMessage(object parameter));
      }
    
    ICommand ChoiceOfErrorCommand  {get;set;}
    
    
    
    public async Task SetErrorMessage(object parameter)
      {
      ErrorDescription errorDescription = new ErrorDescription();
      indexOfError = int.Parse(parameter.ToString());
        if(indexOfError == 1)
        {
          ErrorMessage = "TextOfErrorForClient";
          
        }

        if(indexOfError == 2)
  {
    ErrorMessage = "TextOfErrorForClient2";
    
  }
      }  
}


//View в XAML

<Button
Command = {Binding ChoiceOfErrorCommand}
CommandParameter = "1"
  />




  //запрос для итерирования базы данных:

  


  

