import 'dart:async';
import 'package:aura_sdk/aura_sdk.dart';
import 'package:flutter/foundation.dart';

import 'connect_wallet/aura_connect_wallet.dart';
import 'core/core_data/aura_wallet_core_data.dart';
import 'core/parameters/aura_parameter.dart';
import 'core/types/aura_server_event_type.dart';

class AuraConnectSdk {
  AuraConnectSdk();

  bool _isReadyInit = false;

  String _chainId = '';

  AuraConnectWalletClient? _client;

  Future<void> init({
    AuraWalletEnvironment environment = AuraWalletEnvironment.testNet,
    required String callbackUrl,
    required String yourAppName,
    String yourAppLogo = '',
  }) async {
    switch (environment) {
      case AuraWalletEnvironment.mainNet:
        break;
      case AuraWalletEnvironment.testNet:
        _chainId = 'serenity-testnet-001';
        break;
    }

    _client = AuraConnectWalletClient(
      callbackURL: callbackUrl,
      dAppLogo: yourAppLogo,
      dAppName: yourAppName,
      chainId: _chainId,
    );

    _isReadyInit = true;
  }

  Future<AuraWalletConnectionResult> connectWallet() async {
    if (!_isReadyInit || _client == null) {
      throw UnimplementedError('You must call init before connect wallet');
    }

    return _client!.connectWalletSdk();
  }

  Future<AuraWalletInfoData> requestAccessWallet() async {
    if (!_isReadyInit || _client == null) {
      throw UnimplementedError('You must call init before connect wallet');
    }

    return _client!.requestAccessWalletSdk();
  }

  Future<Map<String, dynamic>> transfer({required TransferParam param}) async {
    if (!_isReadyInit || _client == null) {
      throw UnimplementedError('You must call init before connect wallet');
    }

    return _client!.transfer(
      param: param,
    );
  }

  void addListener(void Function(AuraServerEventType data) listener) {
    _client?.addListener(listener);
  }

  void removeListener(void Function(AuraServerEventType data) listener) {
    _client?.removeListener(listener);
  }

  void clearListener() {
    _client?.clearListener();
  }

  @mustCallSuper
  void connect() {
    _client?.connect();
  }

  @mustCallSuper
  void disconnect() {
    _client?.disconnect();
  }

  @mustCallSuper
  void dispose() {
    _isReadyInit = false;
    _client?.dispose();
  }
}
