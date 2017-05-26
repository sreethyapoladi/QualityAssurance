package navigate;

import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;


public class forward {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.setProperty("webdriver.chrome.driver", "D:\\Chrome\\chromedriver.exe");
		
		WebDriver driver = new ChromeDriver();
		driver.get("http://www.seleniumhq.org");
		driver.navigate().to("https://www.google.com");
		driver.navigate().back();
		driver.navigate().forward();

	}

}
