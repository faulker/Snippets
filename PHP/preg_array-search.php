function preg_array_search( $find, $in_array, $keys_found=Array() ) 
{ 
	if( is_array( $in_array ) ) 
	{ 
		foreach( $in_array as $key=> $val ) 
		{ 
			if( is_array( $val ) ) $this->preg_array_search( $find, $val, $keys_found ); 
			else 
			{ 
				if( preg_match( '/'. $find .'/', $val ) ) $keys_found[] = $key; 
			} 
		} 
		return $keys_found; 
    } 
    return false; 
}