﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using FlutterBinding.Engine.Painting;
using FlutterBinding.Mapping;
using FlutterBinding.UI;
using FlutterSDK;
using FlutterSDK.Animation.Animation;
using FlutterSDK.Animation.Animationcontroller;
using FlutterSDK.Animation.Animations;
using FlutterSDK.Animation.Curves;
using FlutterSDK.Animation.Listenerhelpers;
using FlutterSDK.Animation.Tween;
using FlutterSDK.Animation.Tweensequence;
using FlutterSDK.Foundation;
using FlutterSDK.Foundation._Bitfieldio;
using FlutterSDK.Foundation._Isolatesio;
using FlutterSDK.Foundation._Platformio;
using FlutterSDK.Foundation.Annotations;
using FlutterSDK.Foundation.Assertions;
using FlutterSDK.Foundation.Basictypes;
using FlutterSDK.Foundation.Binding;
using FlutterSDK.Foundation.Bitfield;
using FlutterSDK.Foundation.Changenotifier;
using FlutterSDK.Foundation.Collections;
using FlutterSDK.Foundation.Consolidateresponse;
using FlutterSDK.Foundation.Constants;
using FlutterSDK.Foundation.Debug;
using FlutterSDK.Foundation.Diagnostics;
using FlutterSDK.Foundation.Isolates;
using FlutterSDK.Foundation.Key;
using FlutterSDK.Foundation.Licenses;
using FlutterSDK.Foundation.Node;
using FlutterSDK.Foundation.@object;
using FlutterSDK.Foundation.Observerlist;
using FlutterSDK.Foundation.Platform;
using FlutterSDK.Foundation.Print;
using FlutterSDK.Foundation.Profile;
using FlutterSDK.Foundation.Serialization;
using FlutterSDK.Foundation.Stackframe;
using FlutterSDK.Foundation.Synchronousfuture;
using FlutterSDK.Foundation.Unicode;
using FlutterSDK.Gestures.Arena;
using FlutterSDK.Gestures.Binding;
using FlutterSDK.Gestures.Constants;
using FlutterSDK.Gestures.Converter;
using FlutterSDK.Gestures.Debug;
using FlutterSDK.Gestures.Drag;
using FlutterSDK.Gestures.Dragdetails;
using FlutterSDK.Gestures.Eager;
using FlutterSDK.Gestures.Events;
using FlutterSDK.Gestures.Forcepress;
using FlutterSDK.Gestures.Hittest;
using FlutterSDK.Gestures.Longpress;
using FlutterSDK.Gestures.Lsqsolver;
using FlutterSDK.Gestures.Monodrag;
using FlutterSDK.Gestures.Multidrag;
using FlutterSDK.Gestures.Multitap;
using FlutterSDK.Gestures.Pointerrouter;
using FlutterSDK.Gestures.Pointersignalresolver;
using FlutterSDK.Gestures.Recognizer;
using FlutterSDK.Gestures.Scale;
using FlutterSDK.Gestures.Tap;
using FlutterSDK.Gestures.Team;
using FlutterSDK.Gestures.Velocitytracker;
using FlutterSDK.Material.Appbar;
using FlutterSDK.Material.Debug;
using FlutterSDK.Material.Dialog;
using FlutterSDK.Material.Flatbutton;
using FlutterSDK.Material.Listtile;
using FlutterSDK.Material.Materiallocalizations;
using FlutterSDK.Material.Page;
using FlutterSDK.Material.Progressindicator;
using FlutterSDK.Material.Scaffold;
using FlutterSDK.Material.Scrollbar;
using FlutterSDK.Material.Theme;
using FlutterSDK.Painting.Alignment;
using FlutterSDK.Painting.Basictypes;
using FlutterSDK.Painting.Beveledrectangleborder;
using FlutterSDK.Painting.Binding;
using FlutterSDK.Painting.Borderradius;
using FlutterSDK.Painting.Borders;
using FlutterSDK.Painting.Boxborder;
using FlutterSDK.Painting.Boxdecoration;
using FlutterSDK.Painting.Boxfit;
using FlutterSDK.Painting.Boxshadow;
using FlutterSDK.Painting.Circleborder;
using FlutterSDK.Painting.Clip;
using FlutterSDK.Painting.Colors;
using FlutterSDK.Painting.Continuousrectangleborder;
using FlutterSDK.Painting.Debug;
using FlutterSDK.Painting.Decoration;
using FlutterSDK.Painting.Decorationimage;
using FlutterSDK.Painting.Edgeinsets;
using FlutterSDK.Painting.Flutterlogo;
using FlutterSDK.Painting.Fractionaloffset;
using FlutterSDK.Painting.Geometry;
using FlutterSDK.Painting.Gradient;
using FlutterSDK.Painting.Imagecache;
using FlutterSDK.Painting.Imagedecoder;
using FlutterSDK.Painting.Imageprovider;
using FlutterSDK.Painting.Imageresolution;
using FlutterSDK.Painting.Imagestream;
using FlutterSDK.Painting.Inlinespan;
using FlutterSDK.Painting.Matrixutils;
using FlutterSDK.Painting.Notchedshapes;
using FlutterSDK.Painting.Paintutilities;
using FlutterSDK.Painting.Placeholderspan;
using FlutterSDK.Painting.Roundedrectangleborder;
using FlutterSDK.Painting.Shaderwarmup;
using FlutterSDK.Painting.Shapedecoration;
using FlutterSDK.Painting.Stadiumborder;
using FlutterSDK.Painting.Strutstyle;
using FlutterSDK.Painting.Textpainter;
using FlutterSDK.Painting.Textspan;
using FlutterSDK.Painting.Textstyle;
using FlutterSDK.Physics.Clampedsimulation;
using FlutterSDK.Physics.Frictionsimulation;
using FlutterSDK.Physics.Gravitysimulation;
using FlutterSDK.Physics.Simulation;
using FlutterSDK.Physics.Springsimulation;
using FlutterSDK.Physics.Tolerance;
using FlutterSDK.Physics.Utils;
using FlutterSDK.Rendering.Animatedsize;
using FlutterSDK.Rendering.Binding;
using FlutterSDK.Rendering.Box;
using FlutterSDK.Rendering.Customlayout;
using FlutterSDK.Rendering.Custompaint;
using FlutterSDK.Rendering.Debug;
using FlutterSDK.Rendering.Debugoverflowindicator;
using FlutterSDK.Rendering.Editable;
using FlutterSDK.Rendering.Error;
using FlutterSDK.Rendering.Flex;
using FlutterSDK.Rendering.Flow;
using FlutterSDK.Rendering.Image;
using FlutterSDK.Rendering.Layer;
using FlutterSDK.Rendering.Listbody;
using FlutterSDK.Rendering.Listwheelviewport;
using FlutterSDK.Rendering.Mousetracking;
using FlutterSDK.Rendering.@object;
using FlutterSDK.Rendering.Paragraph;
using FlutterSDK.Rendering.Performanceoverlay;
using FlutterSDK.Rendering.Platformview;
using FlutterSDK.Rendering.Proxybox;
using FlutterSDK.Rendering.Proxysliver;
using FlutterSDK.Rendering.Rotatedbox;
using FlutterSDK.Rendering.Shiftedbox;
using FlutterSDK.Rendering.Sliver;
using FlutterSDK.Rendering.Sliverfill;
using FlutterSDK.Rendering.Sliverfixedextentlist;
using FlutterSDK.Rendering.Slivergrid;
using FlutterSDK.Rendering.Sliverlist;
using FlutterSDK.Rendering.Slivermultiboxadaptor;
using FlutterSDK.Rendering.Sliverpadding;
using FlutterSDK.Rendering.Sliverpersistentheader;
using FlutterSDK.Rendering.Stack;
using FlutterSDK.Rendering.Table;
using FlutterSDK.Rendering.Tableborder;
using FlutterSDK.Rendering.Texture;
using FlutterSDK.Rendering.Tweens;
using FlutterSDK.Rendering.View;
using FlutterSDK.Rendering.Viewport;
using FlutterSDK.Rendering.Viewportoffset;
using FlutterSDK.Rendering.Wrap;
using FlutterSDK.Scheduler.Binding;
using FlutterSDK.Scheduler.Debug;
using FlutterSDK.Scheduler.Priority;
using FlutterSDK.Scheduler.Ticker;
using FlutterSDK.Semantics.Binding;
using FlutterSDK.Semantics.Debug;
using FlutterSDK.Semantics.Semantics;
using FlutterSDK.Semantics.Semanticsevent;
using FlutterSDK.Semantics.Semanticsservice;
using FlutterSDK.Services.Assetbundle;
using FlutterSDK.Services.Binarymessenger;
using FlutterSDK.Services.Binding;
using FlutterSDK.Services.Clipboard;
using FlutterSDK.Services.Fontloader;
using FlutterSDK.Services.Hapticfeedback;
using FlutterSDK.Services.Keyboardkey;
using FlutterSDK.Services.Keyboardmaps;
using FlutterSDK.Services.Messagecodec;
using FlutterSDK.Services.Messagecodecs;
using FlutterSDK.Services.Platformchannel;
using FlutterSDK.Services.Platformmessages;
using FlutterSDK.Services.Platformviews;
using FlutterSDK.Services.Rawkeyboard;
using FlutterSDK.Services.Rawkeyboardandroid;
using FlutterSDK.Services.Rawkeyboardfuchsia;
using FlutterSDK.Services.Rawkeyboardlinux;
using FlutterSDK.Services.Rawkeyboardmacos;
using FlutterSDK.Services.Rawkeyboardweb;
using FlutterSDK.Services.Systemchannels;
using FlutterSDK.Services.Systemchrome;
using FlutterSDK.Services.Systemnavigator;
using FlutterSDK.Services.Systemsound;
using FlutterSDK.Services.Textediting;
using FlutterSDK.Services.Textformatter;
using FlutterSDK.Services.Textinput;
using FlutterSDK.Widgets.Actions;
using FlutterSDK.Widgets.Animatedcrossfade;
using FlutterSDK.Widgets.Animatedlist;
using FlutterSDK.Widgets.Animatedsize;
using FlutterSDK.Widgets.Animatedswitcher;
using FlutterSDK.Widgets.Annotatedregion;
using FlutterSDK.Widgets.App;
using FlutterSDK.Widgets.Async;
using FlutterSDK.Widgets.Automatickeepalive;
using FlutterSDK.Widgets.Banner;
using FlutterSDK.Widgets.Basic;
using FlutterSDK.Widgets.Binding;
using FlutterSDK.Widgets.Bottomnavigationbaritem;
using FlutterSDK.Widgets.Colorfilter;
using FlutterSDK.Widgets.Container;
using FlutterSDK.Widgets.Debug;
using FlutterSDK.Widgets.Dismissible;
using FlutterSDK.Widgets.Disposablebuildcontext;
using FlutterSDK.Widgets.Draggablescrollablesheet;
using FlutterSDK.Widgets.Dragtarget;
using FlutterSDK.Widgets.Editabletext;
using FlutterSDK.Widgets.Fadeinimage;
using FlutterSDK.Widgets.Focusmanager;
using FlutterSDK.Widgets.Focusscope;
using FlutterSDK.Widgets.Focustraversal;
using FlutterSDK.Widgets.Form;
using FlutterSDK.Widgets.Framework;
using FlutterSDK.Widgets.Gesturedetector;
using FlutterSDK.Widgets.Gridpaper;
using FlutterSDK.Widgets.Heroes;
using FlutterSDK.Widgets.Icon;
using FlutterSDK.Widgets.Icondata;
using FlutterSDK.Widgets.Icontheme;
using FlutterSDK.Widgets.Iconthemedata;
using FlutterSDK.Widgets.Image;
using FlutterSDK.Widgets.Imagefilter;
using FlutterSDK.Widgets.Imageicon;
using FlutterSDK.Widgets.Implicitanimations;
using FlutterSDK.Widgets.Inheritedmodel;
using FlutterSDK.Widgets.Inheritednotifier;
using FlutterSDK.Widgets.Inheritedtheme;
using FlutterSDK.Widgets.Layoutbuilder;
using FlutterSDK.Widgets.Listwheelscrollview;
using FlutterSDK.Widgets.Localizations;
using FlutterSDK.Widgets.Mediaquery;
using FlutterSDK.Widgets.Modalbarrier;
using FlutterSDK.Widgets.Navigationtoolbar;
using FlutterSDK.Widgets.Navigator;
using FlutterSDK.Widgets.Nestedscrollview;
using FlutterSDK.Widgets.Notificationlistener;
using FlutterSDK.Widgets.Orientationbuilder;
using FlutterSDK.Widgets.Overlay;
using FlutterSDK.Widgets.Overscrollindicator;
using FlutterSDK.Widgets.Pages;
using FlutterSDK.Widgets.Pagestorage;
using FlutterSDK.Widgets.Pageview;
using FlutterSDK.Widgets.Performanceoverlay;
using FlutterSDK.Widgets.Placeholder;
using FlutterSDK.Widgets.Platformview;
using FlutterSDK.Widgets.Preferredsize;
using FlutterSDK.Widgets.Primaryscrollcontroller;
using FlutterSDK.Widgets.Rawkeyboardlistener;
using FlutterSDK.Widgets.Routes;
using FlutterSDK.Widgets.Safearea;
using FlutterSDK.Widgets.Scrollable;
using FlutterSDK.Widgets.Scrollactivity;
using FlutterSDK.Widgets.Scrollawareimageprovider;
using FlutterSDK.Widgets.Scrollbar;
using FlutterSDK.Widgets.Scrollconfiguration;
using FlutterSDK.Widgets.Scrollcontext;
using FlutterSDK.Widgets.Scrollcontroller;
using FlutterSDK.Widgets.Scrollmetrics;
using FlutterSDK.Widgets.Scrollnotification;
using FlutterSDK.Widgets.Scrollphysics;
using FlutterSDK.Widgets.Scrollposition;
using FlutterSDK.Widgets.Scrollpositionwithsinglecontext;
using FlutterSDK.Widgets.Scrollsimulation;
using FlutterSDK.Widgets.Scrollview;
using FlutterSDK.Widgets.Semanticsdebugger;
using FlutterSDK.Widgets.Shortcuts;
using FlutterSDK.Widgets.Singlechildscrollview;
using FlutterSDK.Widgets.Sizechangedlayoutnotifier;
using FlutterSDK.Widgets.Sliver;
using FlutterSDK.Widgets.Sliverfill;
using FlutterSDK.Widgets.Sliverlayoutbuilder;
using FlutterSDK.Widgets.Sliverpersistentheader;
using FlutterSDK.Widgets.Sliverprototypeextentlist;
using FlutterSDK.Widgets.Spacer;
using FlutterSDK.Widgets.Statustransitions;
using FlutterSDK.Widgets.Table;
using FlutterSDK.Widgets.Text;
using FlutterSDK.Widgets.Textselection;
using FlutterSDK.Widgets.Texture;
using FlutterSDK.Widgets.Tickerprovider;
using FlutterSDK.Widgets.Title;
using FlutterSDK.Widgets.Transitions;
using FlutterSDK.Widgets.Tweenanimationbuilder;
using FlutterSDK.Widgets.Uniquewidget;
using FlutterSDK.Widgets.Valuelistenablebuilder;
using FlutterSDK.Widgets.Viewport;
using FlutterSDK.Widgets.Visibility;
using FlutterSDK.Widgets.Widgetinspector;
using FlutterSDK.Widgets.Widgetspan;
using FlutterSDK.Widgets.Willpopscope;
using SkiaSharp;
using static FlutterSDK.Global;
namespace FlutterSDK.Material.About
{
    internal static class AboutDefaultClass
    {
        /// <Summary>
        /// Displays an [AboutDialog], which describes the application and provides a
        /// button to show licenses for software used by the application.
        ///
        /// The arguments correspond to the properties on [AboutDialog].
        ///
        /// If the application has a [Drawer], consider using [AboutListTile] instead
        /// of calling this directly.
        ///
        /// If you do not need an about box in your application, you should at least
        /// provide an affordance to call [showLicensePage].
        ///
        /// The licenses shown on the [LicensePage] are those returned by the
        /// [LicenseRegistry] API, which can be used to add more licenses to the list.
        ///
        /// The [context], [useRootNavigator] and [routeSettings] arguments are passed to
        /// [showDialog], the documentation for which discusses how it is used.
        /// </Summary>
        internal static void ShowAboutDialog(FlutterSDK.Widgets.Framework.BuildContext context = default(FlutterSDK.Widgets.Framework.BuildContext), string applicationName = default(string), string applicationVersion = default(string), FlutterSDK.Widgets.Framework.Widget applicationIcon = default(FlutterSDK.Widgets.Framework.Widget), string applicationLegalese = default(string), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>), bool useRootNavigator = true, FlutterSDK.Widgets.Navigator.RouteSettings routeSettings = default(FlutterSDK.Widgets.Navigator.RouteSettings))
        {


            DialogDefaultClass.ShowDialog(context: context, useRootNavigator: useRootNavigator, builder: (BuildContext context) =>
            {
                return new AboutDialog(applicationName: applicationName, applicationVersion: applicationVersion, applicationIcon: applicationIcon, applicationLegalese: applicationLegalese, children: children);
            }
            , routeSettings: routeSettings);
        }



        /// <Summary>
        /// Displays a [LicensePage], which shows licenses for software used by the
        /// application.
        ///
        /// The application arguments correspond to the properties on [LicensePage].
        ///
        /// The `context` argument is used to look up the [Navigator] for the page.
        ///
        /// The `useRootNavigator` argument is used to determine whether to push the
        /// page to the [Navigator] furthest from or nearest to the given `context`. It
        /// is `false` by default.
        ///
        /// If the application has a [Drawer], consider using [AboutListTile] instead
        /// of calling this directly.
        ///
        /// The [AboutDialog] shown by [showAboutDialog] includes a button that calls
        /// [showLicensePage].
        ///
        /// The licenses shown on the [LicensePage] are those returned by the
        /// [LicenseRegistry] API, which can be used to add more licenses to the list.
        /// </Summary>
        internal static void ShowLicensePage(FlutterSDK.Widgets.Framework.BuildContext context = default(FlutterSDK.Widgets.Framework.BuildContext), string applicationName = default(string), string applicationVersion = default(string), FlutterSDK.Widgets.Framework.Widget applicationIcon = default(FlutterSDK.Widgets.Framework.Widget), string applicationLegalese = default(string), bool useRootNavigator = false)
        {


            NavigatorDefaultClass.Navigator.Of(context, rootNavigator: useRootNavigator).Push(new MaterialPageRoute<void>(builder: (BuildContext context) => =>new LicensePage(applicationName: applicationName, applicationVersion: applicationVersion, applicationIcon: applicationIcon, applicationLegalese: applicationLegalese)));
        }



        internal static string _DefaultApplicationName(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            Title ancestorTitle = context.FindAncestorWidgetOfExactType();
            return ancestorTitle?.Title ?? Dart.IoDefaultClass.Platform.ResolvedExecutable.Split(Dart.IoDefaultClass.Platform.PathSeparator).ToList().Last();
        }



        internal static string _DefaultApplicationVersion(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return "";
        }



        internal static FlutterSDK.Widgets.Framework.Widget _DefaultApplicationIcon(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return null;
        }



    }

    /// <Summary>
    /// A [ListTile] that shows an about box.
    ///
    /// This widget is often added to an app's [Drawer]. When tapped it shows
    /// an about box dialog with [showAboutDialog].
    ///
    /// The about box will include a button that shows licenses for software used by
    /// the application. The licenses shown are those returned by the
    /// [LicenseRegistry] API, which can be used to add more licenses to the list.
    ///
    /// If your application does not have a [Drawer], you should provide an
    /// affordance to call [showAboutDialog] or (at least) [showLicensePage].
    /// {@tool dartpad --template=stateless_widget_material}
    ///
    /// This sample shows two ways to open [AboutDialog]. The first one
    /// uses an [AboutListTile], and the second uses the [showAboutDialog] function.
    ///
    /// ```dart
    ///
    ///  Widget build(BuildContext context) {
    ///    final TextStyle textStyle = Theme.of(context).textTheme.bodyText2;
    ///    final List<Widget> aboutBoxChildren = <Widget>[
    ///      SizedBox(height: 24),
    ///      RichText(
    ///        text: TextSpan(
    ///          children: <TextSpan>[
    ///            TextSpan(
    ///              style: textStyle,
    ///              text: 'Flutter is Google’s UI toolkit for building beautiful, '
    ///              'natively compiled applications for mobile, web, and desktop '
    ///              'from a single codebase. Learn more about Flutter at '
    ///            ),
    ///            TextSpan(
    ///              style: textStyle.copyWith(color: Theme.of(context).accentColor),
    ///              text: 'https://flutter.dev'
    ///            ),
    ///            TextSpan(
    ///              style: textStyle,
    ///              text: '.'
    ///            ),
    ///          ],
    ///        ),
    ///      ),
    ///    ];
    ///
    ///    return Scaffold(
    ///      appBar: AppBar(
    ///        title: Text('Show About Example'),
    ///      ),
    ///      drawer: Drawer(
    ///        child: SingleChildScrollView(
    ///          child: SafeArea(
    ///            child: AboutListTile(
    ///              icon: Icon(Icons.info),
    ///              applicationIcon: FlutterLogo(),
    ///              applicationName: 'Show About Example',
    ///              applicationVersion: 'August 2019',
    ///              applicationLegalese: '© 2014 The Flutter Authors',
    ///              aboutBoxChildren: aboutBoxChildren,
    ///            ),
    ///          ),
    ///        ),
    ///      ),
    ///      body: Center(
    ///        child: RaisedButton(
    ///          child: Text('Show About Example'),
    ///          onPressed: () {
    ///            showAboutDialog(
    ///              context: context,
    ///              applicationIcon: FlutterLogo(),
    ///              applicationName: 'Show About Example',
    ///              applicationVersion: 'August 2019',
    ///              applicationLegalese: '© 2014 The Flutter Authors',
    ///              children: aboutBoxChildren,
    ///            );
    ///          },
    ///        ),
    ///      ),
    ///    );
    ///}
    /// ```
    /// {@end-tool}
    ///
    /// </Summary>
    public class AboutListTile : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        /// <Summary>
        /// Creates a list tile for showing an about box.
        ///
        /// The arguments are all optional. The application name, if omitted, will be
        /// derived from the nearest [Title] widget. The version, icon, and legalese
        /// values default to the empty string.
        /// </Summary>
        public AboutListTile(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget icon = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), string applicationName = default(string), string applicationVersion = default(string), FlutterSDK.Widgets.Framework.Widget applicationIcon = default(FlutterSDK.Widgets.Framework.Widget), string applicationLegalese = default(string), List<FlutterSDK.Widgets.Framework.Widget> aboutBoxChildren = default(List<FlutterSDK.Widgets.Framework.Widget>), bool dense = default(bool))
        : base(key: key)
        {
            this.Icon = icon;
            this.Child = child;
            this.ApplicationName = applicationName;
            this.ApplicationVersion = applicationVersion;
            this.ApplicationIcon = applicationIcon;
            this.ApplicationLegalese = applicationLegalese;
            this.AboutBoxChildren = aboutBoxChildren;
            this.Dense = dense;
        }
        /// <Summary>
        /// The icon to show for this drawer item.
        ///
        /// By default no icon is shown.
        ///
        /// This is not necessarily the same as the image shown in the dialog box
        /// itself; which is controlled by the [applicationIcon] property.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Icon { get; set; }
        /// <Summary>
        /// The label to show on this drawer item.
        ///
        /// Defaults to a text widget that says "About Foo" where "Foo" is the
        /// application name specified by [applicationName].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        /// <Summary>
        /// The name of the application.
        ///
        /// This string is used in the default label for this drawer item (see
        /// [child]) and as the caption of the [AboutDialog] that is shown.
        ///
        /// Defaults to the value of [Title.title], if a [Title] widget can be found.
        /// Otherwise, defaults to [Platform.resolvedExecutable].
        /// </Summary>
        public virtual string ApplicationName { get; set; }
        /// <Summary>
        /// The version of this build of the application.
        ///
        /// This string is shown under the application name in the [AboutDialog].
        ///
        /// Defaults to the empty string.
        /// </Summary>
        public virtual string ApplicationVersion { get; set; }
        /// <Summary>
        /// The icon to show next to the application name in the [AboutDialog].
        ///
        /// By default no icon is shown.
        ///
        /// Typically this will be an [ImageIcon] widget. It should honor the
        /// [IconTheme]'s [IconThemeData.size].
        ///
        /// This is not necessarily the same as the icon shown on the drawer item
        /// itself, which is controlled by the [icon] property.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget ApplicationIcon { get; set; }
        /// <Summary>
        /// A string to show in small print in the [AboutDialog].
        ///
        /// Typically this is a copyright notice.
        ///
        /// Defaults to the empty string.
        /// </Summary>
        public virtual string ApplicationLegalese { get; set; }
        /// <Summary>
        /// Widgets to add to the [AboutDialog] after the name, version, and legalese.
        ///
        /// This could include a link to a Web site, some descriptive text, credits,
        /// or other information to show in the about box.
        ///
        /// Defaults to nothing.
        /// </Summary>
        public virtual List<FlutterSDK.Widgets.Framework.Widget> AboutBoxChildren { get; set; }
        /// <Summary>
        /// Whether this list tile is part of a vertically dense list.
        ///
        /// If this property is null, then its value is based on [ListTileTheme.dense].
        ///
        /// Dense list tiles default to a smaller height.
        /// </Summary>
        public virtual bool Dense { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {


            return new ListTile(leading: Icon, title: Child ?? new Text(MateriallocalizationsDefaultClass.MaterialLocalizations.Of(context).AboutListTileTitle(ApplicationName ?? AboutDefaultClass._DefaultApplicationName(context))), dense: Dense, onTap: () =>
            {
                AboutDefaultClass.ShowAboutDialog(context: context, applicationName: ApplicationName, applicationVersion: ApplicationVersion, applicationIcon: ApplicationIcon, applicationLegalese: ApplicationLegalese, children: AboutBoxChildren);
            }
            );
        }



    }


    /// <Summary>
    /// An about box. This is a dialog box with the application's icon, name,
    /// version number, and copyright, plus a button to show licenses for software
    /// used by the application.
    ///
    /// To show an [AboutDialog], use [showAboutDialog].
    ///
    /// If the application has a [Drawer], the [AboutListTile] widget can make the
    /// process of showing an about dialog simpler.
    ///
    /// The [AboutDialog] shown by [showAboutDialog] includes a button that calls
    /// [showLicensePage].
    ///
    /// The licenses shown on the [LicensePage] are those returned by the
    /// [LicenseRegistry] API, which can be used to add more licenses to the list.
    /// </Summary>
    public class AboutDialog : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        /// <Summary>
        /// Creates an about box.
        ///
        /// The arguments are all optional. The application name, if omitted, will be
        /// derived from the nearest [Title] widget. The version, icon, and legalese
        /// values default to the empty string.
        /// </Summary>
        public AboutDialog(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), string applicationName = default(string), string applicationVersion = default(string), FlutterSDK.Widgets.Framework.Widget applicationIcon = default(FlutterSDK.Widgets.Framework.Widget), string applicationLegalese = default(string), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>))
        : base(key: key)
        {
            this.ApplicationName = applicationName;
            this.ApplicationVersion = applicationVersion;
            this.ApplicationIcon = applicationIcon;
            this.ApplicationLegalese = applicationLegalese;
            this.Children = children;
        }
        /// <Summary>
        /// The name of the application.
        ///
        /// Defaults to the value of [Title.title], if a [Title] widget can be found.
        /// Otherwise, defaults to [Platform.resolvedExecutable].
        /// </Summary>
        public virtual string ApplicationName { get; set; }
        /// <Summary>
        /// The version of this build of the application.
        ///
        /// This string is shown under the application name.
        ///
        /// Defaults to the empty string.
        /// </Summary>
        public virtual string ApplicationVersion { get; set; }
        /// <Summary>
        /// The icon to show next to the application name.
        ///
        /// By default no icon is shown.
        ///
        /// Typically this will be an [ImageIcon] widget. It should honor the
        /// [IconTheme]'s [IconThemeData.size].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget ApplicationIcon { get; set; }
        /// <Summary>
        /// A string to show in small print.
        ///
        /// Typically this is a copyright notice.
        ///
        /// Defaults to the empty string.
        /// </Summary>
        public virtual string ApplicationLegalese { get; set; }
        /// <Summary>
        /// Widgets to add to the dialog box after the name, version, and legalese.
        ///
        /// This could include a link to a Web site, some descriptive text, credits,
        /// or other information to show in the about box.
        ///
        /// Defaults to nothing.
        /// </Summary>
        public virtual List<FlutterSDK.Widgets.Framework.Widget> Children { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            string name = ApplicationName ?? AboutDefaultClass._DefaultApplicationName(context);
            string version = ApplicationVersion ?? AboutDefaultClass._DefaultApplicationVersion(context);
            Widget icon = ApplicationIcon ?? AboutDefaultClass._DefaultApplicationIcon(context);
            return new AlertDialog(content: new ListBody(children: new List<Widget>() { new Row(crossAxisAlignment: CrossAxisAlignment.Start, children: new List<Widget>() { }), ? Children :}), actions: new List<Widget>(){new FlatButton(child:new Text(MateriallocalizationsDefaultClass.MaterialLocalizations.Of(context).ViewLicensesButtonLabel), onPressed:() => {
AboutDefaultClass.ShowLicensePage(context:context, applicationName:ApplicationName, applicationVersion:ApplicationVersion, applicationIcon:ApplicationIcon, applicationLegalese:ApplicationLegalese);
}
), new FlatButton(child:new Text(MateriallocalizationsDefaultClass.MaterialLocalizations.Of(context).CloseButtonLabel), onPressed:() => {
NavigatorDefaultClass.Navigator.Pop(context);
}
)}, scrollable: true);
        }



    }


    /// <Summary>
    /// A page that shows licenses for software used by the application.
    ///
    /// To show a [LicensePage], use [showLicensePage].
    ///
    /// The [AboutDialog] shown by [showAboutDialog] and [AboutListTile] includes
    /// a button that calls [showLicensePage].
    ///
    /// The licenses shown on the [LicensePage] are those returned by the
    /// [LicenseRegistry] API, which can be used to add more licenses to the list.
    /// </Summary>
    public class LicensePage : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates a page that shows licenses for software used by the application.
        ///
        /// The arguments are all optional. The application name, if omitted, will be
        /// derived from the nearest [Title] widget. The version and legalese values
        /// default to the empty string.
        ///
        /// The licenses shown on the [LicensePage] are those returned by the
        /// [LicenseRegistry] API, which can be used to add more licenses to the list.
        /// </Summary>
        public LicensePage(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), string applicationName = default(string), string applicationVersion = default(string), FlutterSDK.Widgets.Framework.Widget applicationIcon = default(FlutterSDK.Widgets.Framework.Widget), string applicationLegalese = default(string))
        : base(key: key)
        {
            this.ApplicationName = applicationName;
            this.ApplicationVersion = applicationVersion;
            this.ApplicationIcon = applicationIcon;
            this.ApplicationLegalese = applicationLegalese;
        }
        /// <Summary>
        /// The name of the application.
        ///
        /// Defaults to the value of [Title.title], if a [Title] widget can be found.
        /// Otherwise, defaults to [Platform.resolvedExecutable].
        /// </Summary>
        public virtual string ApplicationName { get; set; }
        /// <Summary>
        /// The version of this build of the application.
        ///
        /// This string is shown under the application name.
        ///
        /// Defaults to the empty string.
        /// </Summary>
        public virtual string ApplicationVersion { get; set; }
        /// <Summary>
        /// The icon to show below the application name.
        ///
        /// By default no icon is shown.
        ///
        /// Typically this will be an [ImageIcon] widget. It should honor the
        /// [IconTheme]'s [IconThemeData.size].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget ApplicationIcon { get; set; }
        /// <Summary>
        /// A string to show in small print.
        ///
        /// Typically this is a copyright notice.
        ///
        /// Defaults to the empty string.
        /// </Summary>
        public virtual string ApplicationLegalese { get; set; }

        public new FlutterSDK.Material.About._LicensePageState CreateState() => new _LicensePageState();


    }


    public class _LicensePageState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.About.LicensePage>
    {
        public _LicensePageState()
        { }
        internal virtual List<FlutterSDK.Widgets.Framework.Widget> _Licenses { get; set; }
        internal virtual bool _Loaded { get; set; }

        public new void InitState()
        {
            base.InitState();
            _InitLicenses();
        }




        private async Future<object> _InitLicenses()
        {
            int debugFlowId = -1;

            await foreach (LicenseEntry license in LicensesDefaultClass.LicenseRegistry.Licenses)
            {
                if (!Mounted)
                {
                    return;
                }


                List<LicenseParagraph> paragraphs = await BindingDefaultClass.SchedulerBinding.Instance.ScheduleTask(license.Paragraphs.ToList, PriorityDefaultClass.Priority.Animation, debugLabel: "License");
                if (!Mounted)
                {
                    return;
                }

                SetState(() =>
                {
                    _Licenses.Add(new Padding(padding: EdgeInsets.Symmetric(vertical: 18.0), child: new Text("🍀‬", textAlign: TextAlign.Center)));
                    _Licenses.Add(new Container(decoration: new BoxDecoration(border: new Border(bottom: new BorderSide(width: 0.0))), child: new Text(license.Packages.Join(", "), style: new TextStyle(fontWeight: Dart.UI.UiDefaultClass.FontWeight.Bold), textAlign: TextAlign.Center)));
                    foreach (LicenseParagraph paragraph in paragraphs)
                    {
                        if (paragraph.Indent == LicensesDefaultClass.LicenseParagraph.CenteredIndent)
                        {
                            _Licenses.Add(new Padding(padding: EdgeInsets.Only(top: 16.0), child: new Text(paragraph.Text, style: new TextStyle(fontWeight: Dart.UI.UiDefaultClass.FontWeight.Bold), textAlign: TextAlign.Center)));
                        }
                        else
                        {

                            _Licenses.Add(new Padding(padding: EdgeInsetsDirectional.Only(top: 8.0, start: 16.0 * paragraph.Indent), child: new Text(paragraph.Text)));
                        }

                    }

                }
                );
            }

            SetState(() =>
            {
                _Loaded = true;
            }
            );

        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            string name = Widget.ApplicationName ?? AboutDefaultClass._DefaultApplicationName(context);
            string version = Widget.ApplicationVersion ?? AboutDefaultClass._DefaultApplicationVersion(context);
            Widget icon = Widget.ApplicationIcon ?? AboutDefaultClass._DefaultApplicationIcon(context);
            MaterialLocalizations localizations = MateriallocalizationsDefaultClass.MaterialLocalizations.Of(context);
            return new Scaffold(appBar: new AppBar(title: new Text(localizations.LicensesPageTitle)), body: Localizations.Override(locale: new Locale("en", "US"), context: context, child: new DefaultTextStyle(style: ThemeDefaultClass.Theme.Of(context).TextTheme.Caption, child: new SafeArea(bottom: false, child: new Scrollbar(child: new ListView(padding: EdgeInsets.Symmetric(horizontal: 8.0, vertical: 12.0), children: new List<Widget>() { new Text(name, style: ThemeDefaultClass.Theme.Of(context).TextTheme.Headline5, textAlign: TextAlign.Center) }))))));
        }



    }

}
