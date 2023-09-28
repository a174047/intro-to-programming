namespace TodosApi.Controllers;

public class TodoListController : ControllerBase
{
    private readonly IManageTodoLists _todoListManager;

    public TodoListController(IManageTodoLists todoListManager)
    {
        _todoListManager = todoListManager;
    }
    // Get /todo-list
    [HttpPost("/todo-list")]
    public async Task<ActionResult> AddTodoList([FromBody] TodoCreateRequest request)
    {


        TodoItemResponse response = await _todoListManager.AddTodoItemAsync(request);
        return StatusCode(201, response);
    }

    [HttpGet("/todo-list")]
    public async Task<ActionResult> GetTodoListAsync()
    {
        TodoListSummaryResponse response = await _todoListManager.GetAllTodosAsync();
        return Ok(response);
    }
}
