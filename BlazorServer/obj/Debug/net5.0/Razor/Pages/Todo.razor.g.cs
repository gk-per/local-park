#pragma checksum "C:\src\theme-park\samples\Blazor\BlazorServer\Pages\Todo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04d6594f136617c4d21ea3c5fad97bb83de805df"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\src\theme-park\samples\Blazor\BlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\src\theme-park\samples\Blazor\BlazorServer\_Imports.razor"
using System.Collections.Immutable;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\src\theme-park\samples\Blazor\BlazorServer\_Imports.razor"
using System.Collections.ObjectModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\src\theme-park\samples\Blazor\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\src\theme-park\samples\Blazor\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\src\theme-park\samples\Blazor\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\src\theme-park\samples\Blazor\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\src\theme-park\samples\Blazor\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\src\theme-park\samples\Blazor\BlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\src\theme-park\samples\Blazor\BlazorServer\_Imports.razor"
using BlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\src\theme-park\samples\Blazor\BlazorServer\_Imports.razor"
using BlazorServer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\src\theme-park\samples\Blazor\BlazorServer\_Imports.razor"
using BlazorServer.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\src\theme-park\samples\Blazor\BlazorServer\_Imports.razor"
using BlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\src\theme-park\samples\Blazor\BlazorServer\_Imports.razor"
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
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, "Todo (");
            __builder.AddContent(2, 
#nullable restore
#line 5 "C:\src\theme-park\samples\Blazor\BlazorServer\Pages\Todo.razor"
           todos.Count(todo => !todo.IsDone)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(3, ")");
            __builder.CloseElement();
#nullable restore
#line 7 "C:\src\theme-park\samples\Blazor\BlazorServer\Pages\Todo.razor"
 foreach (var todo in todos)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "input-group mb-3");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "input-group-prepend");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "input-group-text");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "type", "checkbox");
            __builder.AddAttribute(12, "checked", 
#nullable restore
#line 12 "C:\src\theme-park\samples\Blazor\BlazorServer\Pages\Todo.razor"
                                                 todo.IsDone

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 12 "C:\src\theme-park\samples\Blazor\BlazorServer\Pages\Todo.razor"
                                                                           async e => await HandleTodoDoneAsync(todo, (bool)e.Value)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "class", "btn btn-outline-secondary");
            __builder.AddAttribute(17, "type", "button");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\src\theme-park\samples\Blazor\BlazorServer\Pages\Todo.razor"
                                                                                async e => await HandleDeleteTodoAsync(todo)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(19, "<span class=\"oi oi-trash\" aria-hidden=\"true\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "class", "form-control");
            __builder.AddAttribute(23, "value", 
#nullable restore
#line 18 "C:\src\theme-park\samples\Blazor\BlazorServer\Pages\Todo.razor"
                                            todo.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 18 "C:\src\theme-park\samples\Blazor\BlazorServer\Pages\Todo.razor"
                                                                     async e => await HandleTodoTitleChangeAsync(todo, (string)e.Value)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 20 "C:\src\theme-park\samples\Blazor\BlazorServer\Pages\Todo.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "placeholder", "Something todo");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\src\theme-park\samples\Blazor\BlazorServer\Pages\Todo.razor"
                                            newTodo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newTodo = __value, newTodo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\src\theme-park\samples\Blazor\BlazorServer\Pages\Todo.razor"
                  AddTodoAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(32, "Add Todo");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\src\theme-park\samples\Blazor\BlazorServer\Pages\Todo.razor"
       

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
