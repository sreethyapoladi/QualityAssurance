package account;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.interactions.Actions;

public class register {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.setProperty("webdriver.chrome.driver", "C:\\selenium\\chromedriver.exe");
		
		WebDriver driver = new ChromeDriver();
		driver.get("https://www.sears.com");
		driver.manage().window().maximize();
		
		WebElement Menu=driver.findElement(By.xpath(".//*[@id='universalSignInBtns']/button"));// menu item
		
		WebElement SubMenu=driver.findElement(By.xpath(".//*[@id='subnavDD_myProfile']/li[12]/button"));// sub-menu item

		Actions action = new Actions(driver);// actions performing
		action.moveToElement(Menu).perform();
		action.moveToElement(SubMenu).perform();
		
		driver.findElement(By.id("email")).sendKeys("sreethyapoladi@gmail.com");// giving credentials
		driver.findElement(By.id("emailConfirm")).sendKeys("sreethyapoladi@gmail.com");
		driver.findElement(By.id("password")).sendKeys("sreethya@03");
		 
		driver.findElement(By.id("togglePwd")).click();
		driver.findElement(By.xpath(".//*[@id='universalSignInBtns']/button")).click();
	}
}