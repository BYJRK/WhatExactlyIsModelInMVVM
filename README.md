# MVVM 中的 Model 究竟是什么？

- M：Model，即模型，它是应用程序的数据模型，用于存储应用程序的数据。Model 通常包含应用程序的业务逻辑，例如数据验证、数据访问、数据操作等。
- V：View，即视图，是 MVVM 中的视图，它是用户界面，通常是一个页面或者一个控件。View 通常包含用户界面的布局、样式、事件处理等。（`MainWindow.xaml.cs`）
- VM：ViewModel，即视图模型，是 MVVM 中的视图模型，它是连接 Model 和 View 的桥梁，它负责将 Model 中的数据绑定到 View 中，同时负责将 View 中的事件传递给 Model。ViewModel 通常包含 Model 的引用，以及一些命令、属性、事件等。（`MainViewModel.cs`）

例如在下面的例子中，我们通常会把 ViewModel 中的一个 Collection 里面的数据类型理解为 Model：

```csharp
public ViewModel : ObservableObject
{
    public ObservableCollection<Student> Students { get; set; }
}
```

但是，如果这个数据类型（也就是上面的 `Student` 类）出于某些原因，需要具备通知功能，此时应该怎么做？如果修改了这个类，它还算不算是 Model 了呢？

这就是本项目试图探讨的问题：


> 在实际的 WPF 项目中，Model 究竟是哪些类？哪些类属于严格意义上的 Model？
