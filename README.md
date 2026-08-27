# Tanzy.Xunit
This project contains a collection of helpers for xUnit.

## Installation
Release packages can be installed from NuGet:

- Use `Tanzy.Xunit` with xUnit v2:

  ```shell
  dotnet add package Tanzy.Xunit
  ```

- Use `Tanzy.Xunit.v3` with xUnit v3:

  ```shell
  dotnet add package Tanzy.Xunit.v3
  ```

The v2 attributes are in the `Tanzy.Xunit.Categories` namespace. The v3
attributes are in the `Tanzy.Xunit.v3.Categories` namespace.


## Usage
Below is how you use this package

Import the namespace for the package you installed:

```csharp
// Tanzy.Xunit (xUnit v2)
using Tanzy.Xunit.Categories;

// Tanzy.Xunit.v3 (xUnit v3)
using Tanzy.Xunit.v3.Categories;
```

### Categories
One issue with xUnit traits is that you normally have to write `[Trait("Category", "Bug")]`.

It is easier to write `[Bug]`.

This project enables the following categories:

```csharp
[Fact]
[Category("Sample")]
public void CategorySampleTest()
{
}

[Fact]
[Bug]
public void BugNoNameTest()
{
}

[Fact]
[Bug(88)]
public void BugNumberTest()
{
}

[Fact]
[Bug("Something")]
public void BugNameTest()
{
}

[Fact]
[UserStory()]
public void UserStoryNoNameTest()
{
}

[Fact]
[UserStory(33)]
public void UserStoryNumberTest()
{
}

[Fact]
[UserStory("A Story")]
public void UserStoryNameTest()
{
}

[Fact]
[Task()]
public void UserStoryNoNameTest()
{
}

[Fact]
[Task(33)]
public void UserStoryNumberTest()
{
}

[Fact]
[Task("A Story")]
public void UserStoryNameTest()
{
}
```

### Class Level Categories
Some people also like to mark whether their tests are unit, integration, or system tests. The following attributes have
been added to enable a class to be marked as containing appropriate type of tests.

```csharp

[UnitTests]
public class ThisContainsUnitTests
{
}

[IntegrationTests]
public class ThisContainsIntegrationTests
{
}

[SystemTests]
public class ThisContainsSystemTests
{
}
```


## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)
