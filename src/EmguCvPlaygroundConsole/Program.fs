namespace EmguCvPlayground

open CommandLine
open Prelude
open System

open Emgu.CV
open Emgu.CV.Structure
open Emgu.CV.CvEnum

module console1 =
    // https://github.com/Simon-Campbell/FsEmguCvExample/blob/master/FsEmguCvExample/Script.fsx
    let putText = CvInvoke.PutText
    let createNamedWindow = CvInvoke.NamedWindow
    let showImage = CvInvoke.Imshow
    let waitKey x = CvInvoke.WaitKey x
    let destroyWindow = CvInvoke.DestroyWindow
    let createBgr b g r = Bgr(b, g, r)

    let createMat (rows : int) cols depthType channels = new Mat(rows, cols, depthType, channels)

    let makeWindow windowName = 
        let blue = createBgr 255.0 0.0 0.0
        let green = createBgr 0.0 255.0 0.0
        let point = System.Drawing.Point(10, 80)

        createNamedWindow windowName

        use img = createMat 200 400 DepthType.Cv8U 3

        img.SetTo(blue.MCvScalar)

        putText (img, "Hello, World", point, FontFace.HersheyComplex, 1.0, green.MCvScalar)

        showImage (windowName, img)

        waitKey -1 |> ignore

        destroyWindow windowName

    [<EntryPoint>]
    let main argv = 
        printfn "%A" argv

        let parsedCommand = parse (System.Reflection.Assembly.GetExecutingAssembly().GetName().Name) argv

        match parsedCommand.Error with
            | Some e -> 
                printfn "%s" <| formatExceptionDisplay e
                printfn "%s" parsedCommand.Usage
            | None -> 
                printfn "%A" parsedCommand

        makeWindow "Test Window"

        printfn "Hit any key to exit."
        System.Console.ReadKey() |> ignore
        0
