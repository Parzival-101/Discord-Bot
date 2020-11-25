using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using DSharpPlus.Interactivity;
using System;
using System.Threading.Tasks;

/* Create our class and extend from IModule */
public class BasicCommandsModule : IModule
{
    /* Commands in DSharpPlus.CommandsNext are identified by supplying a Command attribute to a method in any class you've loaded into it. */
    /* The description is just a string supplied when you use the help command included in CommandsNext. */
    

    [Command("alive")]
    [Description("Simple command to test if the bot is running!")]
    public async Task Alive(CommandContext ctx)
    {
        /* Trigger the Typing... in discord */
        await ctx.TriggerTypingAsync();

        /* Send the message "I'm Alive!" to the channel the message was recieved from */
        await ctx.RespondAsync("I'm alive!");
    }
    
    //Greet with mention
    [Command("greet")]
    [Description("Simple command to greet the user!")]
    public async Task GreetCommand(CommandContext ctx, DiscordMember member)
    {
        /* Trigger the Typing... in discord */
        await ctx.TriggerTypingAsync();

        /* Send the greeting message to the channel the message was recieved from  according to current time*/
       if (0 <=DateTime.Now.Hour && DateTime.Now.Hour <12 )
       {
         await ctx.RespondAsync($"Good Morning, {member.Mention}!");
       }else   if (12 <=DateTime.Now.Hour && DateTime.Now.Hour <17 )
       {
         await ctx.RespondAsync($"Good Afternoon, {member.Mention}!");
       }else
        await ctx.RespondAsync($"Good Evening, {member.Mention}!");
    }

    [Command("interact")]
[Description("Simple command to test interaction!")]
public async Task Interact(CommandContext ctx)
{
    /* Trigger the Typing... in discord */
    await ctx.TriggerTypingAsync();

    /* Send the message "I'm Alive!" to the channel the message was recieved from */
    await ctx.RespondAsync("How are you today?");

    var intr = ctx.Client.GetInteractivityModule(); // Grab the interactivity module
    var reminderContent = await intr.WaitForMessageAsync(
        c => c.Author.Id == ctx.Message.Author.Id, // Make sure the response is from the same person who sent the command
        TimeSpan.FromSeconds(60) // Wait 60 seconds for a response instead of the default 30 we set earlier!
    );
    // You can also check for a specific message by doing something like
    // c => c.Content == "something"

    // Null if the user didn't respond before the timeout
    if(reminderContent == null)
    {
        await ctx.RespondAsync("Sorry, I didn't get a response!");
        return;
    }

    // Homework: have this change depending on if they say "good" or "bad", etc.
    await ctx.RespondAsync("Thank you for telling me how you are!");
}
//Picking an random number
[Command("pick")]
[Description("Pick an number between two numbers")]
public async Task Pick(CommandContext ctx ,int min ,int max)
{
var random = new Random();
await ctx.RespondAsync($"Your pick is :{random.Next(min,max)}");
}

}