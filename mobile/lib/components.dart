import 'package:flutter/material.dart';
import 'ledcontroller.dart';

class HeigthSpace extends StatelessWidget {
  final double heigth;
  const HeigthSpace({Key? key, required this.heigth}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Container(
      height: heigth,
    );
  }
}

class WidthSpace extends StatelessWidget {
  final double width;

  const WidthSpace({Key? key, required this.width}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Container(
      width: width,
    );
  }
}

class TurnOnButton extends StatelessWidget {
  const TurnOnButton({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return TextButton(
      child: const Text(
        "Ligar",
        style: TextStyle(color: Colors.black),
        ),
      style: ButtonStyle(
        backgroundColor: MaterialStateProperty.all(Colors.green),
        minimumSize: MaterialStateProperty.all(const Size(100, 40))
      ),
      onPressed: () {
        LedController.instance.turnOn();
      },
    );
  }
}

class TurnOffButton extends StatelessWidget {
  const TurnOffButton({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return TextButton(
      child: const Text(
        "Desligar",
        style: TextStyle(color: Colors.black),
        ),
      style: ButtonStyle(
        backgroundColor: MaterialStateProperty.all(Colors.redAccent),
        minimumSize: MaterialStateProperty.all(const Size(100, 40))
      ),
      onPressed: () {
        LedController.instance.turnOff();
      },
    );
  }
}