using Banking.Domain;

namespace Banking.Test;
public class MakingDeposits
{
    [Fact]
    public void MakingADepositIncreasesBalance()
    {
        //given
        var account = new Account();
        var openingBalance = account.GetBalance();
        var amountToDeposit = 100M;

        //when 
        account.Deposit(amountToDeposit);

        //then 
        Assert.Equal(openingBalance + amountToDeposit, account.GetBalance());
    }

}
