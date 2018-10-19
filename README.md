# ScrollView Bug Example
A complete example of a potential bug in xamarin forms android.

When trying to remove the scroll bar on a scrollview in android, it won't be removed if the scrollview has a horizontal orientation. I encountered this issue in a production app, once I had exhausted my options I created this sample to recreate the issue and it persists in a fresh project, indicating it is likely a bug with Xamarin itself.

Usually the scroll bar is removed by the following code:

```csharp
this.VerticalScrollBarEnabled = false;
this.HorizontalScrollBarEnabled = false;
```

I have tested this issue in the following Xamarin Forms versions:

- 3.1.0.637273
- 3.3.0.912540 (Latest version 19/10/2018)



## Running The Project

I have setup the project to try and affect the Scroll View using 2 popular implementations, using an effect & a custom renderer.



There are 2 pages that use each implementation, simply go to the App.cs file in the shared project and comment the pages in or out (didn't want to mess about with a masterdetailpage for this example).

```csharp
public App()
{
    InitializeComponent();
    //MainPage = new EffectPage();
    MainPage = new RendererPage();
}
```



When running the project on iOS, both implementations work as expected and remove the scroll bar.

<img src="https://github.com/Axemasta/ScrollView-Bug-Example/blob/master/assets/effect-ios.gif" width="250"><img src="https://github.com/Axemasta/ScrollView-Bug-Example/blob/master/assets/renderer-ios.gif" width="250">


When running the project on Android, the vertical scroll bar will be removed however the horizontal scrollbar won't be removed.

<img src="https://github.com/Axemasta/ScrollView-Bug-Example/blob/master/assets/effect-droid.gif" width="250"><img src="https://github.com/Axemasta/ScrollView-Bug-Example/blob/master/assets/renderer-droid.gif" width="250">