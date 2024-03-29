# Xunit
This project contains a collection of helpers for XUnit. Some bits have been inspired by other repositories, or bits of code from Stackoverflow

## Installation
Release packages can be installed from NuGet.


## Usage
Below is how you use this package

### Categories
One issue with xUnit is the Traits can be a pain in the backside, it issue being that you have to do ```[Trait("Category", "Bug")]```

It would be easier to just do ```[Bug]```

This project enables the following categories, please fee free to add a Pull Request with more

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
Some people also like to mark if there tests are Unit, Integration or System tests. So the following attributes have
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
