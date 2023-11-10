Random dice = new Random();
int luck = dice.Next(100);

string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };

int rastgelesayi()
{
    return dice.Next(4);
}
string[][] lists = {good,bad,neutral};
string sondeger = string.Format("{0} {1}", text[rastgelesayi()], lists[luck > 75 ? 0 : (luck > 25 ? 2 : 1)][rastgelesayi()]);
Console.WriteLine(sondeger);

