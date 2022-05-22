import 'package:flutter/material.dart';
import 'panel.dart';

class Home extends StatelessWidget {
  const Home({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text("Painel LED")
      ),
      body: const Panel()
    );
  }
}
