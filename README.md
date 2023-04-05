# Towny Calculator

### This is a simple calculator app for the Towny minecraft plugin.

It looks like this:

![1680718019524](https://cdn.glitch.global/e778e17c-75b5-43df-ae17-f2a1107ac22b/Towny_Calculator_aqngEUjO3T.png?v=1680719405375)

To use it, you just have to input the amount of Gold (the currency) that you have or the amount of chunks that you want to get.

---

**This is a sample of the code of one of the buttons:**

```csharp
//check for errors
try
{   
    //assign a custom variable to the "chunks1" text field:
    int chunks = int.Parse(chunks1.Text);

    //do the equation:
    double math = chunks * 16;
      
    //set the value of the goldRES1 field:
    goldRES1.Text = math.ToString();
} catch
{
    //display the error message
    MessageBox.Show("'It may not be empty \nnor messed up'\n\t\t~ Grandpa", "Read the quote!", MessageBoxButtons.OK);
```

**It's just the same code twice, but with some slight changes.**

> To be honest, it's just simple code, so you can code it yourself or even make a better version of it.
