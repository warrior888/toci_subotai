import React, {Component} from 'react';
import {View, Text, Image, StyleSheet} from 'react-native';

import Img from '../assets/images/image.png';
import Icon from 'react-native-vector-icons/Ionicons';

export default class ShopCardItem extends Component {
  render() {
    return (
      <View style={styles.main}>
        <Image style={styles.image} source={Img} />
        <Text style={styles.title}>Tradycyjne mydło...</Text>
        <Text style={styles.count}>Ilość: 1</Text>
        <Text style={styles.price}>10 zł</Text>
        <Icon name="md-create" size={20} color="#915e8d" style={styles.icon_edit} />
      </View>
    );
  }
}

const styles = StyleSheet.create({
  main: {
    borderRadius: 10,
    margin: 15,
  },
  image: {
    height: 50,
    width: 50,
    borderRadius: 10,
  },
  title: {
    position: 'absolute',
    fontWeight: 'bold',
    marginLeft: 60,
  },
  count: {
    position: 'absolute',
    marginLeft: 60,
    marginTop: 25,
  },
  icon_edit: {
    position: 'absolute',
    right: 10,
    top: 12.5,
  },
  price: {
    position: 'absolute',
    top: 15,
    right: 75,
  },
});
