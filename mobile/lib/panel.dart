import 'package:flutter/material.dart';
import 'components.dart';

class Panel extends StatelessWidget {
  const Panel({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Column(
      mainAxisAlignment: MainAxisAlignment.center,
      children: [
        const Text(
          "Painel de Controle",
          style: TextStyle(fontSize: 34.0, fontWeight: FontWeight.bold),
        ),
        const HeigthSpace(heigth: 12.0),
        Row(
          mainAxisAlignment: MainAxisAlignment.center,
          children: const [
            TurnOnButton(),
            WidthSpace(width: 10.0),
            TurnOffButton()
          ],
        )
      ],
    );
  }
}