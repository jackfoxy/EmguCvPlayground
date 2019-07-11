(*** hide ***)
// This block of code is omitted in the generated HTML documentation. Use 
// it to define helpers that you do not want to show in the documentation.
#I "../../bin/EmguCvPlayground"

(**
EmguCvPlayground
======================

Documentation

<div class="row">
  <div class="span1"></div>
  <div class="span6">
    <div class="well well-small" id="nuget">
      The EmguCvPlayground library can be <a href="https://nuget.org/packages/EmguCvPlayground">installed from NuGet</a>:
      <pre>PM> Install-Package EmguCvPlayground</pre>
    </div>
  </div>
  <div class="span1"></div>
</div>

Use Fable Femto to manage npm packages
https://fable.io/blog/Introducing-Femto.html

Notes
-------

[Homography (computer vision)](https://en.wikipedia.org/wiki/Homography_(computer_vision))
[Structure from motion](https://en.wikipedia.org/wiki/Structure_from_motion)
[Regard3D](http://www.regard3d.org/index.php)
[3DScanExpert](https://3dscanexpert.com)
[Photogrammetry](https://en.wikipedia.org/wiki/Photogrammetry)
[OpenCV examples](https://docs.opencv.org/4.1.0/examples.html)
[César Souza](http://crsouza.com/)
[Accord .NET Framework](http://accord-framework.net/)
[EMGU CV tutorial C#](http://www.emgu.com/wiki/index.php/Tutorial)
[Open CV sharp](https://github.com/shimat/opencvsharp)  //alternate to EMGU CV
[C# OpenCvSharp Mat Examples](https://csharp.hotexamples.com/examples/OpenCvSharp/Mat/-/php-mat-class-examples.html)
[F# to solve a sudoku puzzle from the 9x9 grid image. Uses Emgu (OpenCV)](https://github.com/Rrogntudju/FSharp-Solve-Sudoku-From-Image)


search github for opencv csharp


*)
#r "EmguCvPlayground.dll"
open EmguCvPlayground

printfn "hello = %i" <| Library.hello 0

(**
Some more info

Samples & documentation
-----------------------

The library comes with comprehensible documentation. 
It can include tutorials automatically generated from `*.fsx` files in [the content folder][content]. 
The API reference is automatically generated from Markdown comments in the library implementation.

 * [Tutorial](tutorial.html) contains a further explanation of this sample library.

 * [API Reference](reference/index.html) contains automatically generated documentation for all types, modules
   and functions in the library. This includes additional brief samples on using most of the
   functions.
 
Contributing and copyright
--------------------------

The project is hosted on [GitHub][gh] where you can [report issues][issues], fork 
the project and submit pull requests. If you're adding a new public API, please also 
consider adding [samples][content] that can be turned into a documentation. You might
also want to read the [library design notes][readme] to understand how it works.

The library is available under Public Domain license, which allows modification and 
redistribution for both commercial and non-commercial purposes. For more information see the 
[License file][license] in the GitHub repository. 

  [content]: https://github.com/fsprojects/EmguCvPlayground/tree/master/docs/content
  [gh]: https://github.com/fsprojects/EmguCvPlayground
  [issues]: https://github.com/fsprojects/EmguCvPlayground/issues
  [readme]: https://github.com/fsprojects/EmguCvPlayground/blob/master/README.md
  [license]: https://github.com/fsprojects/EmguCvPlayground/blob/master/LICENSE.txt
*)
