import 'package:flutter/material.dart';
import 'home.dart';

class App extends StatelessWidget {
  const App({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: "LED Controller",
      theme: ThemeData(
        primarySwatch: Colors.cyan,
        brightness: Brightness.dark
      ),
      home: const Home()
    );
  }
}