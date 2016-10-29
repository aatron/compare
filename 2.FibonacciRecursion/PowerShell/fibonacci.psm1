function Calculate() {
    param([int] $sequence)

    if ( $sequence -le 1 ) {
        return 1;
    }

    return (Calculate ($sequence - 1)) + (Calculate ($sequence - 2))
}
