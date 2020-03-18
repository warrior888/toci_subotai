import React, {Component} from 'react';
import {View, StyleSheet, Button, ScrollView, Text} from 'react-native';
import ShopCardItem from '../screens/ShopCardItem';
import {Divider} from 'react-native-elements';

export default class ShopCard extends Component {
  render() {
    return (
      <View style={styles.main}>
        <ScrollView>
          <ShopCardItem />
          <ShopCardItem />
          <ShopCardItem />
          <ShopCardItem />
          <ShopCardItem />
          <ShopCardItem />
          <ShopCardItem />
          <ShopCardItem />
          <ShopCardItem />
          <ShopCardItem />
          <ShopCardItem />
          <ShopCardItem />
          <ShopCardItem />
          <ShopCardItem />
          <ShopCardItem />
          <ShopCardItem />
        </ScrollView>
        <View style={{backgroundColor: 'white'}}>
          <Divider style={styles.divider} />
          <Text style={styles.all}>Łączna kwota: 10 zł</Text>
          <Button
            stlye={styles.submit}
            color="#2ecc71"
            title="Złóż zamówienie"
          />
        </View>
      </View>
    );
  }
}

const styles = StyleSheet.create({
  main: {
    height: '100%',
    backgroundColor: 'white',
  },
  divider: {
    height: 2.5,
    backgroundColor: '#915e8d',
    bottom: 10,
    width: '50%',
    marginLeft: '25%',
  },
  submit: {
    marginBottom: 10,
  },
  all: {
    marginTop: 10,
    marginLeft: 10,
    marginBottom: 10,
  },
});
