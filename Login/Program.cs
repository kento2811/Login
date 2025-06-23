def dang_nhap(username, password, remember_me):
    if not username or not password:
        return "Điền đầy đủ thông tin"

    if not username.replace("_", "").isalnum():
        return "Username không được chứa ký tự đặc biệt"

    user = tim_user_trong_database(username)
    if not user or user.password != password:
        return "Username hoặc password không đúng"

    if remember_me:
        tao_session(ngay_het_han = 7)
    else:
        tao_session(ngay_het_han = "khi đóng trình duyệt")

    return f"Chào {username}"
