public static class HelloWorld
{
    public static string Hello() => "Hello, World!";
    public class HelloWorldTests
{
    
    public void Say_hi()
    {
        Assert.Equal("Hello, World!", HelloWorld.Hello());
    }
}

}
