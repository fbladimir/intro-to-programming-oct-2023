using Banking.Domain;

namespace Banking.Test;
public class NewAccounts
{

    [Fact]

    public void NewAccountsHaveCorrectOpeningBalance()
    {
        //write the code you wish you had 

        //given - i have a new acconut 
        Account account = new Account();

        //when I ask it for it's blanace 
        decimal openingBalance = account.GetBalance();

        //then it is 5000 bucks 

        Assert.Equal(5000M, openingBalance);



    }
}
