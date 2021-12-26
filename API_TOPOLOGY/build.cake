var target = Argument("target", "Default");
Task("Default")
  .Does(() =>
{
  MSBuild("./src/CakeDemo.sln");
});
RunTarget(target);