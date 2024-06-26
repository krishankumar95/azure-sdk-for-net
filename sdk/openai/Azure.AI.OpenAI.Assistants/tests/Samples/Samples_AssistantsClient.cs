// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Azure.AI.OpenAI.Assistants.Samples;

public partial class Samples_AssistantsClient
{
    [Test]
    [Ignore("Only for sample compilation verification")]
    public async Task OverviewSample()
    {
        // Patterned from https://platform.openai.com/docs/assistants/overview

        bool isAzureOpenAI = false;
        string azureResourceUrl = "https://my-resource.openai.azure.com";
        string nonAzureApiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");
        string azureApiKey = Environment.GetEnvironmentVariable("AOAI_API_KEY");

        #region Snippet:OverviewCreateClient
        AssistantsClient client = isAzureOpenAI
            ? new AssistantsClient(new Uri(azureResourceUrl), new AzureKeyCredential(azureApiKey))
            : new AssistantsClient(nonAzureApiKey);
        #endregion

        // Step 1: Create an assistant
        #region Snippet:OverviewCreateAssistant
        Response<Assistant> assistantResponse = await client.CreateAssistantAsync(
            new AssistantCreationOptions("gpt-4-1106-preview")
            {
                Name = "Math Tutor",
                Instructions = "You are a personal math tutor. Write and run code to answer math questions.",
                Tools = { new CodeInterpreterToolDefinition() }
            });
        Assistant assistant = assistantResponse.Value;
        #endregion

        // Intermission: assistant should now be listed

        Response<PageableList<Assistant>> assistantListResponse = await client.GetAssistantsAsync();

        // Step 2: Create a thread
        #region Snippet:OverviewCreateThread
        Response<AssistantThread> threadResponse = await client.CreateThreadAsync();
        AssistantThread thread = threadResponse.Value;
        #endregion

        // Step 3: Add a message to a thread
        #region Snippet:OverviewCreateMessage
        Response<ThreadMessage> messageResponse = await client.CreateMessageAsync(
            thread.Id,
            MessageRole.User,
            "I need to solve the equation `3x + 11 = 14`. Can you help me?");
        ThreadMessage message = messageResponse.Value;
        #endregion

        // Intermission: message is now correlated with thread
        // Intermission: listing messages will retrieve the message just added

        Response<PageableList<ThreadMessage>> messagesListResponse = await client.GetMessagesAsync(thread.Id);
        Assert.That(messagesListResponse.Value.Data[0].Id == message.Id);

        // Step 4: Run the assistant

        #region Snippet:OverviewCreateRun
        Response<ThreadRun> runResponse = await client.CreateRunAsync(
            thread.Id,
            new CreateRunOptions(assistant.Id)
            {
                AdditionalInstructions = "Please address the user as Jane Doe. The user has a premium account.",
            });
        ThreadRun run = runResponse.Value;
        #endregion

        #region Snippet:OverviewWaitForRun
        do
        {
            await Task.Delay(TimeSpan.FromMilliseconds(500));
            runResponse = await client.GetRunAsync(thread.Id, runResponse.Value.Id);
        }
        while (runResponse.Value.Status == RunStatus.Queued
            || runResponse.Value.Status == RunStatus.InProgress);
        #endregion

        #region Snippet:OverviewListUpdatedMessages
        Response<PageableList<ThreadMessage>> afterRunMessagesResponse
            = await client.GetMessagesAsync(thread.Id);
        IReadOnlyList<ThreadMessage> messages = afterRunMessagesResponse.Value.Data;

        // Note: messages iterate from newest to oldest, with the messages[0] being the most recent
        foreach (ThreadMessage threadMessage in messages)
        {
            Console.Write($"{threadMessage.CreatedAt:yyyy-MM-dd HH:mm:ss} - {threadMessage.Role,10}: ");
            foreach (MessageContent contentItem in threadMessage.ContentItems)
            {
                if (contentItem is MessageTextContent textItem)
                {
                    Console.Write(textItem.Text);
                }
                else if (contentItem is MessageImageFileContent imageFileItem)
                {
                    Console.Write($"<image from ID: {imageFileItem.FileId}");
                }
                Console.WriteLine();
            }
        }
        #endregion
    }
}
