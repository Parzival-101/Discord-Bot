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
}