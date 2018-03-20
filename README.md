# CustomActionResult

# Why would I write a custom ActionResult
Yes, good question. There is plenty supported in ASP.NET 5. But sometimes you ends up in a situation,
where you need something special. When I developed Your Favorite Snippet Tool, I needed to transfer binary in a certain way, to provide best user experience. I created a custom ActionResult to handle it.

# ActionResult in MVC 6 compared to earlier versions
ActionResults have changed a bit, since the prior versions of MVC. Yes, you still have to inherit from ActionResult and yes you still have to override a ExecuteResult method, when making custom ActionResults.

The most noticeable difference, is that in MVC 6 ExecuteResult have another signature compared to prior version, and there is also a ExecuteResultAsync added.

# ExecuteResult for ASP.NET MVC 5 and Prior

public abstract void ExecuteResult(ControllerContext context)

# ExecuteResult for ASP.NET MVC 6

  public virtual Task ExecuteResultAsync(ActionContext context)
  public virtual void ExecuteResult(ActionContext context)

Two thing you might notice, the methods in MVC 6 are using virtual methods, and ActionContext instead of ControllerContext. There is nothing much to say about the contexts, they are very similar. By using virtual method there is no override constrains. It means that you can override either ExecuteResultAsync, ExecuteResult or both, but are not forced to.
