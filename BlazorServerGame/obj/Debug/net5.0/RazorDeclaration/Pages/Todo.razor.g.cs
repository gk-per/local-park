// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\src\local-park\BlazorServerGame\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\src\local-park\BlazorServerGame\_Imports.razor"
using System.Collections.Immutable;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\src\local-park\BlazorServerGame\_Imports.razor"
using System.Collections.ObjectModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\src\local-park\BlazorServerGame\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\src\local-park\BlazorServerGame\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\src\local-park\BlazorServerGame\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\src\local-park\BlazorServerGame\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\src\local-park\BlazorServerGame\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\src\local-park\BlazorServerGame\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\src\local-park\BlazorServerGame\_Imports.razor"
using BlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\src\local-park\BlazorServerGame\_Imports.razor"
using BlazorServer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\src\local-park\BlazorServerGame\_Imports.razor"
using BlazorServer.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\src\local-park\BlazorServerGame\_Imports.razor"
using BlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\src\local-park\BlazorServerGame\_Imports.razor"
using Orleans.Streams;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public partial class Todo : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\src\local-park\BlazorServerGame\Pages\Todo.razor"
       

    private Guid ownerKey = Guid.Empty;
    private TodoKeyedCollection todos = new TodoKeyedCollection();
    private string newTodo;
    private StreamSubscriptionHandle<TodoNotification> subscription;

    protected override async Task OnInitializedAsync()
    {
        // subscribe to updates for the current list
        // note that the blazor task scheduler is reentrant
        // therefore notifications can and will come through when the code is stuck at an await
        subscription = await TodoService.SubscribeAsync(ownerKey, notification => InvokeAsync(() => HandleNotificationAsync(notification)));

        // get all items from the cluster
        foreach (var item in await TodoService.GetAllAsync(ownerKey))
        {
            todos.Add(item);
        }

        await base.OnInitializedAsync();
    }

    public void Dispose()
    {
        // unsubscribe from the orleans stream - best effort
        try
        {
            subscription?.UnsubscribeAsync();
        }
        catch
        {
            // noop
        }
    }

    private async Task AddTodoAsync()
    {
        if (!string.IsNullOrWhiteSpace(newTodo))
        {
            // create a new todo
            var todo = new TodoItem(Guid.NewGuid(), newTodo, false, ownerKey);

            // add it to the cluste
            await TodoService.SetAsync(todo);

            // the above this will generate a stream notification that may or may not have come through while we were awaiting the call
            // therefore only add it to the interface if it is not there yet
            if (todos.TryGetValue(todo.Key, out var current))
            {
                // latest one wins
                if (todo.Timestamp > current.Timestamp)
                {
                    todos[todos.IndexOf(current)] = todo;
                }
            }
            else
            {
                todos.Add(todo);
            }

            // reset the text box
            newTodo = null;
        }
    }

    private Task HandleNotificationAsync(TodoNotification notification)
    {
        // was the item removed
        if (notification.Item == null)
        {
            // attempt to remove it from the user interface
            if (todos.Remove(notification.ItemKey))
            {
                StateHasChanged();
            }
            return Task.CompletedTask;
        }

        if (todos.TryGetValue(notification.Item.Key, out var current))
        {
            // latest one wins
            if (notification.Item.Timestamp > current.Timestamp)
            {
                todos[todos.IndexOf(current)] = notification.Item;
                StateHasChanged();
            }
            return Task.CompletedTask;
        }

        todos.Add(notification.Item);
        StateHasChanged();
        return Task.CompletedTask;
    }

    private void TryUpdateCollection(TodoItem item)
    {
        // we need to cater for reentrancy allowing a stream notification during the previous await
        // the notification may have even have deleted the item - if so then deletion wins
        if (todos.TryGetValue(item.Key, out var current))
        {
            // latest one wins
            if (item.Timestamp > current.Timestamp)
            {
                todos[todos.IndexOf(current)] = item;
            }
        }
    }

    private async Task HandleTodoDoneAsync(TodoItem item, bool isDone)
    {
        var updated = item.WithIsDone(isDone);
        await TodoService.SetAsync(updated);
        TryUpdateCollection(updated);
    }

    private async Task HandleTodoTitleChangeAsync(TodoItem item, string title)
    {
        var updated = item.WithTitle(title);
        await TodoService.SetAsync(updated);
        TryUpdateCollection(updated);
    }

    private async Task HandleDeleteTodoAsync(TodoItem item)
    {
        await TodoService.DeleteAsync(item.Key);
        todos.Remove(item.Key);
    }

    private class TodoKeyedCollection : KeyedCollection<Guid, TodoItem>
    {
        protected override Guid GetKeyForItem(TodoItem item) => item.Key;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TodoService TodoService { get; set; }
    }
}
#pragma warning restore 1591
