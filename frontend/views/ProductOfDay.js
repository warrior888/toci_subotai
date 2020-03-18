import React, {Component} from 'react';
import {
  View,
  Text,
  Button,
  Image,
  StyleSheet,
} from 'react-native';
import {Divider} from 'react-native-elements';

import Img from '../assets/images/image.png';

export default class ProductOfDay extends Component {

  render() {
    return (
      <View>
        <Text style={styles.title}>Produkt dnia</Text>
        <Divider style={styles.divider} />
        <Image style={styles.image} source={Img} />
        <Text style={styles.description}>
          Tradycyjne mydło toaletowe lawendowe z masłem shea
        </Text>
        <Text style={styles.price}>24,00 zł</Text>
        <View style={styles.button}>
          <Button color="#915e8d" title="Kup Teraz" style={styles.button} />
        </View>
        <View style={styles.button}>
          <Button
            color="#915e8d"
            title="Do Koszyka"
            style={styles.button}
          />
        </View>
      </View>
    );
  }
}

const styles = StyleSheet.create({
  title: {
    textAlign: 'center',
    fontSize: 30,
    color: '#915e8d',
    marginBottom: 5,
  },
  divider: {
    height: 2.5,
    backgroundColor: '#915e8d',
    marginBottom: 10,
    width: '50%',
    marginLeft: '25%',
  },
  image: {
    borderRadius: 10,
    marginLeft: '12%',
    marginBottom: 10,
  },
  description: {
    fontSize: 17.5,
    textAlign: 'center',
  },
  price: {
    fontSize: 20,
    fontWeight: 'bold',
    textAlign: 'center',
    color: '#e74c3c',
  },
  button: {
    marginLeft: '12%',
    marginTop: 10,
    height: 50,
    width: '75%',
  },
});
